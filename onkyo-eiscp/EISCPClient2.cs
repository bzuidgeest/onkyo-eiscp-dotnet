using Eiscp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{

    //https://gist.github.com/yojimbo87/3116116

    public class EISCPClient2 : IISCPClient
    {
        public ReceiverInfo ReceiverInfo { get; private set; }

        public bool Connected { get; private set; }

        
        private Socket socket;
        private SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs();
        private SocketAsyncEventArgs socketAsyncEventArgsSend = new SocketAsyncEventArgs();

        public EISCPClient2(ReceiverInfo receiverInfo) 
        { 
            this.ReceiverInfo = receiverInfo;
        }

        public void Connect()
        {
            socket = new Socket(ReceiverInfo.IPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socketAsyncEventArgs.Completed += SocketAsyncEventArgs_Completed;
            socketAsyncEventArgs.RemoteEndPoint = ReceiverInfo.IPEndPoint;
            socketAsyncEventArgs.UserToken = socket;

            socketAsyncEventArgsSend.Completed += SocketAsyncEventArgs_Completed;
            socketAsyncEventArgsSend.RemoteEndPoint = ReceiverInfo.IPEndPoint;
            socketAsyncEventArgsSend.UserToken = socket;

            byte[] buffer = new byte[1024];
            socketAsyncEventArgs.SetBuffer(buffer, 0, buffer.Length);

            bool willRaiseEvent = socket.ConnectAsync(socketAsyncEventArgs);

            if (willRaiseEvent == false)
            {
                ProcessConnect(socketAsyncEventArgs);
            }
        }

        private void SocketAsyncEventArgs_Completed(object? sender, SocketAsyncEventArgs e)
        {
            switch (e.LastOperation)
            {
                case SocketAsyncOperation.Connect:
                    ProcessConnect(e);
                    break;
                case SocketAsyncOperation.Receive:
                    ProcessReceive(e);
                    break;
                case SocketAsyncOperation.Send:
                    ProcessSend(e);
                    break;
                case SocketAsyncOperation.Disconnect:
                    Connected = false;
                    break;
                default:
                    throw new Exception("Invalid operation completed.");
            }
        }

        private void ProcessConnect(SocketAsyncEventArgs eventArgs)
        {
            if (eventArgs.SocketError == SocketError.Success)
            {
                Connected = true;

                bool willRaiseEvent = socket.ReceiveAsync(eventArgs);
                if (willRaiseEvent == false)
                {
                    ProcessReceive(eventArgs);
                }

            }
            else
            {
                throw new SocketException((int)eventArgs.SocketError);
            }
        }

        private void ProcessReceive(SocketAsyncEventArgs eventArgs)
        {
            if (eventArgs.SocketError == SocketError.Success)
            {
                //byte[] foo = eventArgs.Buffer.Take(2).ToArray();
                //if (BitConverter.IsLittleEndian)
                //{
                //    Array.Reverse(foo);
                //}
                Console.WriteLine("Received from server: {0}", Encoding.UTF8.GetString(eventArgs.Buffer, 0, eventArgs.BytesTransferred));
                //Console.WriteLine("{0}", BitConverter.ToInt16(foo, 0));

                //// Data has now been sent and received from the server. Disconnect from the server
                //Socket socket = eventArgs.UserToken as Socket;
                //socket.Shutdown(SocketShutdown.Send);
                //socket.Close();
                //ClientDoneResetEvent.Set();
            }
            else
            {
                throw new SocketException((int)eventArgs.SocketError);
            }
        }

        private void ProcessSend(SocketAsyncEventArgs eventArgs)
        {
            if (eventArgs.SocketError == SocketError.Success)
            {
                //Console.WriteLine("Sent 'Hello World' to the server");

                //Read data sent from the server
                //Socket socket = eventArgs.UserToken as Socket;
                bool willRaiseEvent = socket.ReceiveAsync(eventArgs);

                if (!willRaiseEvent)
                {
                    ProcessReceive(eventArgs);
                }
            }
            else
            {
                throw new SocketException((int)eventArgs.SocketError);
            }
        }

        public void SendCommand(string command)
        {
            IscpMessage message = new IscpMessage(command);

            EiscpPacket packet = new EiscpPacket(message);

            socketAsyncEventArgsSend.SetBuffer(packet.Bytes, 0, packet.Bytes.Length);
            bool willRaiseEvent = socket.SendAsync(socketAsyncEventArgsSend);

            if (!willRaiseEvent)
            {
                ProcessSend(socketAsyncEventArgsSend);
            }

            //socket.Send(packet.Bytes);
        }

        public void Disconnect()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
