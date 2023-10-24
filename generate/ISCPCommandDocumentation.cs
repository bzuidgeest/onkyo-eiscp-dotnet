using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public class ISCPCommandDocumentation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Aliasses { get; set; }

        public Dictionary<string, ISCPCommandValueDocumentation> Values { get; set; }

        public ISCPCommandDocumentation() { }
    }
}
