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

using System.IO.Ports;

namespace Eiscp.Core
{
    public class ISCPSerialClient : ISCPClient
    {

        private SerialPort port;
        private List<byte> serialReceiveBuffer = new List<byte>();

        public ISCPSerialClient(ReceiverInfo receiverInfo)
            : base(receiverInfo)
        {
            port = new SerialPort(receiverInfo.SerialPortName, 9600, Parity.None, 8, StopBits.One);
        }

        private protected override async void ReceiveMessage()
        {

            while (receiveCancelationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    // maybe switch to Port.BaseStream
                    if (serialReceiveBuffer.Contains(0x1A)) //EOF
                    {
                        try
                        {
                            Debug.WriteLine($"Received: {Encoding.ASCII.GetString(serialReceiveBuffer.ToArray(), 0, serialReceiveBuffer.IndexOf(0x1A) + 1)}");
                            receivedMessageQueue.Add(new ReceiverResponse(ReceiverInfo, serialReceiveBuffer.GetRange(0, serialReceiveBuffer.IndexOf(0x1A) + 1).ToArray()), receiveCancelationTokenSource.Token);
                            serialReceiveBuffer.RemoveRange(0, serialReceiveBuffer.IndexOf(0x1A) + 1);
                        }
                        catch (OperationCanceledException ex) { Debug.WriteLine("ReceiveMessageLoop canceled"); }
                    }
                    Thread.Sleep(200);
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

                    port.Write(iSCPMessage, 0, iSCPMessage.Length);

                    //if (bytesSend > 0 && data.Array != null)
                    //{
                    //    Debug.WriteLine($"Send: {Encoding.ASCII.GetString(data.Array, 0, bytesSend)}");
                    //}
                }
                catch (OperationCanceledException ex) { Debug.WriteLine("SendMessageLoop canceled"); }

            }
            Debug.WriteLine("SendMessageLoop ended!");
        }

        public override async Task Connect()
        {
            //await port.Open();
            port.DataReceived += Port_DataReceived;
            port.Open();
            // call base to start all queue's and threads
            await base.Connect();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            

            while (port.BytesToRead > 0)
            {
                byte b = (byte)port.ReadByte();
                serialReceiveBuffer.Add(b);

                
            }
        }

        public new void Disconnect()
        {
            // call base to stop everthing.
            base.Disconnect();

            port.Close();
        }
    }
}
