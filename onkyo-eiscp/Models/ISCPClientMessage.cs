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
    public class ISCPClientMessage
    {
        private byte[] _payload = new byte[0];
        public ISCPClientMessage(byte[] payload)
        {
            _payload = payload;
        }

        public ISCPClientMessage(string payload) :
            this(Encoding.ASCII.GetBytes(payload))
        {
        }

        public byte[] MessageBytes
        {
            get
            {
                // ! = start character
                // 1 = destination unit type, 1 means receiver
                // End character may be CR, LF or CR+LF, according to doc
                byte[] MessageBytes = new byte[_payload.Length + 3];
                MessageBytes[0] = (byte)'!';
                MessageBytes[1] = (byte)'1';
                _payload.CopyTo(MessageBytes, 2);
                MessageBytes[MessageBytes.Length - 1] = (byte)'\r';

                return MessageBytes;
            }
        }

        public byte[] PayloadBytes
        {
            get { return _payload; }
        }

        public string PayLoadString
        {
            get { return Encoding.ASCII.GetString(_payload); }
        }

        public static ISCPClientMessage Parse(byte[] message)
        {
            //const char EOF = '\x1a';

            // EOF = 0x1A
            // LF = 0x0A
            // CR = 0x0D
            if (message[0] == (byte)'!'
                && message[1] == (byte)'1' // <--- the only number the doc talks about, but is it the only number possible in reality?
                && (message[message.Length - 1] == 0x0D || message[message.Length - 1] == 0x0A || message[message.Length - 2] == 0x0D && message[message.Length - 1] == 0x0A))
            {
                byte[] payload;
                if (message[message.Length - 2] == 0x0D && message[message.Length - 1] == 0x0A)
                {
                    payload = new byte[message.Length - 4];
                    Array.Copy(message, 2, payload, 0, payload.Length - 4);
                }
                else
                {
                    payload = new byte[message.Length - 3];
                    Array.Copy(message, 2, payload, 0, payload.Length - 3);
                }
                return new ISCPClientMessage(payload);
            }
            else
            {
                if (message[0] == (byte)'!'
                && message[1] == (byte)'1' // <--- the only number the doc talks about, but is it the only number possible in reality?
                && message[message.Length - 1] == 0x1A)
                {
                    throw new Exception("Invalid client message, but looks like it is a devicemessage. Use the correct class.");
                }
                throw new Exception("Invalid client message");
            }
        }
    }
}
