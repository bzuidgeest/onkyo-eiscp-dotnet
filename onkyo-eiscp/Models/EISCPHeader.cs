using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    public class EISCPHeader
    {
        public byte[] magic = new byte[0];
        public int headerSize;
        public int messageSize;
        public byte version;
        public byte[] reserved = new byte[0];
    }
}
