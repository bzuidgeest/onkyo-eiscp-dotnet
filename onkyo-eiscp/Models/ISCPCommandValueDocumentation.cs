using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    public class ISCPCommandValueDocumentation
    {
        public string Name { get; set; } = "Unknown";
        public string Description { get; set; } = "Unknown";

        public string[] SupportedDevices { get; set; } = { };

        public ISCPCommandValueDocumentation() { }
    }
}
