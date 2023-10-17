using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kvp = System.Collections.Generic.KeyValuePair<string, string>;

namespace Eiscp.Core
{
    public class CmdDetailedResult
    {
        public string CommandName;
        public string CommandDescription;
        public string ValueName;
        public string ValueDescription;
        /// <summary>
        /// only used for audio or video information
        /// </summary>
        public IEnumerable<kvp> ParsedValueNameToValue;
    }
}
