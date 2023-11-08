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
    public class ISCPNetworkClient : ISCPClient
    {
        
        private Socket socket;

        public ISCPNetworkClient(ReceiverInfo receiverInfo) 
            : base(receiverInfo)
        { 
            socket = new Socket(ReceiverInfo.IPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
        private protected override async void ReceiveMessage()
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

        private protected override async void SendMessage()
        {
            byte[] iSCPMessage;
            while (sendCancelationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    iSCPMessage = sendMessageQueue.Take(sendCancelationTokenSource.Token);

                    EISCPPacket message = new EISCPPacket(iSCPMessage);

                    ArraySegment<byte> data = new ArraySegment<byte>(message.Bytes);

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

        public override async Task Connect()
        {
            await socket.ConnectAsync(ReceiverInfo.IPEndPoint);

            // call base to start all queue's and threads
            await base.Connect();
        }

        public new void Disconnect()
        {
            // call base to stop everthing.
            base.Disconnect();

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
