using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    public class ISCPCommandDocumentation
    {
        public string Zone { get; set; } = "Unknown";
        public string Name { get; set; } = "Unknown";
        public string Description { get; set; } = "Unknown";

        public List<ISCPCommandValueDocumentation> Values { get; set; } = new List<ISCPCommandValueDocumentation>();

        public ISCPCommandDocumentation() { }
    }
}