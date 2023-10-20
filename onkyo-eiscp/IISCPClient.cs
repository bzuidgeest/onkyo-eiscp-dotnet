using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public interface IISCPClient
    {
        public void SendCommand(string command);

        public void Connect();
        public void Disconnect();
    }
}
