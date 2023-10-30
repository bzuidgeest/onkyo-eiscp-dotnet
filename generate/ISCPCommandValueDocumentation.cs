using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public class ISCPCommandValueDocumentation
    {
        public string[] Name { get; set; }
        public string Description { get; set; }

        public string[] SupportedDevices { get; set; }

        public ISCPCommandValueDocumentation() { }
    }
}
