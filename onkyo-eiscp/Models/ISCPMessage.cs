﻿using System;
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
    public class ISCPMessage
    {
        public ISCPMessage(string command)
        {
            // ! = start character
            // 1 = destination unit type, 1 means receiver
            // End character may be CR, LF or CR+LF, according to doc
            byte[] data = Encoding.ASCII.GetBytes(command);
            CommandWithHeader = new byte[data.Length + 3];
            CommandWithHeader[0] = (byte)'!';
            CommandWithHeader[1] = (byte)'1';
            data.CopyTo(CommandWithHeader, 2);
            CommandWithHeader[CommandWithHeader.Length - 1] = (byte)'\r';
        }

        public byte[] CommandWithHeader
        {
            get;
            private set;
        }

        //public static byte[] Parse(byte[] data)
        //{
        //    const char EOF = '\x1a';

        //    Debug.Assert(data[0] == (byte)'!' && data[1] == (byte)'1');

        //    byte last = data[data.Length - 1];
        //    Debug.Assert(last == (byte)EOF || last == (byte)'\n' || last == (byte)'\r');

        //    // drop first 2 and last 3 characters
        //    byte[] unpacked = new byte[data.Length - 5];
        //    Array.Copy(data, 2, unpacked, 0, unpacked.Length);
        //    return unpacked;
        //}
    }
}
