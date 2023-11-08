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
    public abstract partial class ISCPClient : IISCPClient
    {
        public ReceiverInfo ReceiverInfo { get; private protected set; }

        public bool Connected { get; private protected set; }


        private protected BlockingCollection<byte[]> sendMessageQueue = new BlockingCollection<byte[]>();
        private protected BlockingCollection<ReceiverResponse> receivedMessageQueue = new BlockingCollection<ReceiverResponse>();

        private Thread sendMessageWorker;
        private Thread receiveMessageWorker;
        private Thread processReceivedMessageWorker;

        private protected CancellationTokenSource receiveCancelationTokenSource = new CancellationTokenSource();
        private protected CancellationTokenSource sendCancelationTokenSource = new CancellationTokenSource();
        private protected CancellationTokenSource processCancelationTokenSource = new CancellationTokenSource();

        public ISCPClient(ReceiverInfo receiverInfo)
        {
            this.ReceiverInfo = receiverInfo;

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

                        // todo implement event here.
                        Console.WriteLine($"Processsing: {Encoding.ASCII.GetString(message.Message, 0, message.Message.Length)}");
                    }
                }
                catch (OperationCanceledException ex) { Debug.WriteLine("ProcessingMessageLoop canceled"); }

            }

            Debug.WriteLine("ProcessingMessageLoop ended!");
        }

        private protected abstract void ReceiveMessage();

        private protected abstract void SendMessage();

        public virtual Task Connect()
        {

            Connected = true;
            sendMessageWorker.Start();
            receiveMessageWorker.Start();
            processReceivedMessageWorker.Start();

            return Task.CompletedTask;
        }

        public void SendCommand(string command)
        {
            ISCPClientMessage message = new ISCPClientMessage(command);

            
            
            sendMessageQueue.Add(message.MessageBytes);
        }

        public virtual void Disconnect()
        {
            sendCancelationTokenSource.Cancel();
            receiveCancelationTokenSource.Cancel();
            processCancelationTokenSource.Cancel();

        }
    }
}
