using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    /// <summary>
    /// Deals with formatting and parsing data wrapped in an ISCP
    /// containers.
    /// </summary>
    /// The docs say:
    /// 
    ///    "ISCP (Integra Serial Control Protocol) consists of three
    ///    command characters and parameter character(s) of variable
    ///    length."
    ///
    /// It seems this was the original protocol used for communicating
    /// via a serial cable.
    public class ISCPDeviceMessage
    {


        private ISCPDeviceMessage()
        {
        }


        public byte[] MessageBytes
        {
            get;
            private set;
        }

        public byte[] PayloadBytes
        {
            get;
            private set;
        }

        public string PayLoadString
        {
            get;
            private set;
        }

        public ReceiverInfo Source
        {
            get;
            private set;
        }

        public static ISCPDeviceMessage Parse(byte[] message, ReceiverInfo source)
        {
            //const char EOF = '\x1a';

            // EOF = 0x1A
            // LF = 0x0A
            // CR = 0x0D
            if (message[0] == (byte)'!'
                && message[1] == (byte)'1' // <--- the only number the doc talks about, but is it the only number possible in reality?
                && message[message.Length - 1] == 0x1A)
            {
                byte[] payload = new byte[message.Length - 3];
                Array.Copy(message, 2, payload, 0, payload.Length - 3);
                return new ISCPDeviceMessage() { PayloadBytes = payload };
            }
            else
            {
                if (message[0] == (byte)'!'
                && message[1] == (byte)'1' // <--- the only number the doc talks about, but is it the only number possible in reality?
                && (message[message.Length - 1] == 0x0D || message[message.Length - 1] == 0x0A || message[message.Length - 2] == 0x0D && message[message.Length - 1] == 0x0A))
                {
                    throw new Exception("Invalid device message, but looks like it is a clientmessage. Use the correct class.");
                }
                throw new Exception("Invalid device message");
            }
        }
    }
}
