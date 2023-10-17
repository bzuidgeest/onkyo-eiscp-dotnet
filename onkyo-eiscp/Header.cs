using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public class Header
    {
        public byte[] magic;
        public int headerSize;
        public int messageSize;
        public byte version;
        public byte[] reserved;
    }
}
