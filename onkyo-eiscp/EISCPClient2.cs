using Eiscp.Core.Interfaces;
using Eiscp.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public class EISCPClient2 : IISCPClient
    {
        public ReceiverInfo ReceiverInfo { get; private set; }

        public bool Connected { get; private set; }
        
        private Socket socket;

        private BlockingCollection<byte[]> sendMessageQueue = new BlockingCollection<byte[]>();
        private BlockingCollection<ReceiverResponse> receivedMessageQueue = new BlockingCollection<ReceiverResponse>();
        
        private Thread sendMessageWorker;
        private Thread receiveMessageWorker;
        private Thread processReceivedMessageWorker;

        private CancellationTokenSource receiveCancelationTokenSource = new CancellationTokenSource();
        private CancellationTokenSource sendCancelationTokenSource = new CancellationTokenSource();
        private CancellationTokenSource processCancelationTokenSource = new CancellationTokenSource();

        public EISCPClient2(ReceiverInfo receiverInfo) 
        { 
            this.ReceiverInfo = receiverInfo;
            socket = new Socket(ReceiverInfo.IPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            this.receiveMessageWorker = new Thread(new ThreadStart(ReceiveMessage));
            this.sendMessageWorker = new Thread(new ThreadStart(SendMessage));
            this.processReceivedMessageWorker = new Thread(new ThreadStart(ProcessReceivedMessage));
        }

        private void ProcessReceivedMessage()
        {
            ReceiverResponse message;
            while (processCancelationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    message = receivedMessageQueue.Take(processCancelationTokenSource.Token);
                    
                    if (message.Message.Length > 0)
                    {
                        string temp = Encoding.ASCII.GetString(message.Message, 0, message.Message.Length);
                        Console.WriteLine($"Processsing: {Encoding.ASCII.GetString(message.Message, 0, message.Message.Length)}");
                    }
                }
                catch (OperationCanceledException ex) { Debug.WriteLine("ProcessingMessageLoop canceled"); }

            }
            Debug.WriteLine("ProcessingMessageLoop ended!");
        }

        private async void ReceiveMessage()
        {
            while (receiveCancelationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    ArraySegment<byte> data = new ArraySegment<byte>(buffer);
                    int bytesReceived = await socket.ReceiveAsync(data, receiveCancelationTokenSource.Token);
                    
                    if (bytesReceived > 0 && data.Array != null)
                    {
                        Debug.WriteLine($"Received: {Encoding.ASCII.GetString(buffer, 0, bytesReceived)}");
                        receivedMessageQueue.Add(new ReceiverResponse(ReceiverInfo, data.Slice(0, bytesReceived).ToArray()), receiveCancelationTokenSource.Token);
                    }
                }
                catch (OperationCanceledException ex) { Debug.WriteLine("ReceiveMessageLoop canceled"); }
            }
            Debug.WriteLine("ReceiveMessageLoop ended!");
        }

        private async void SendMessage()
        {
            byte[] message;
            while (sendCancelationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    message = sendMessageQueue.Take(sendCancelationTokenSource.Token);
                    ArraySegment<byte> data = new ArraySegment<byte>(message);

                    int bytesSend = await socket.SendAsync(data, sendCancelationTokenSource.Token);
                    if (bytesSend > 0 && data.Array != null)
                    {
                        Debug.WriteLine($"Send: {Encoding.ASCII.GetString(data.Array, 0, bytesSend)}");
                    }
                }
                catch (OperationCanceledException ex) { Debug.WriteLine("SendMessageLoop canceled"); }

            }
            Debug.WriteLine("SendMessageLoop ended!");
        }

        public async Task Connect()
        {
            await socket.ConnectAsync(ReceiverInfo.IPEndPoint);

            Connected = true;
            sendMessageWorker.Start();
            receiveMessageWorker.Start();
            processReceivedMessageWorker.Start();
        }
        public void SendCommand(string command)
        {
            IscpMessage message = new IscpMessage(command);

            EiscpPacket packet = new EiscpPacket(message);

            sendMessageQueue.Add(packet.Bytes);
        }

        public void Disconnect()
        {
            sendCancelationTokenSource.Cancel();
            receiveCancelationTokenSource.Cancel();
            processCancelationTokenSource.Cancel();

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
