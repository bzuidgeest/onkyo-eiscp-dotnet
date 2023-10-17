using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    public class ReceiverInfo
    {
        public string Category { get; private set; } = "";
        public string ModelName { get; private set; } = "";
        public int Port { get; private set; } = 0;

        public string AreaCode { get; private set; } = "";

        public string Identifier { get; private set; } = "";
        private ReceiverInfo() { }  

        public static ReceiverInfo ParseDiscoveryResponse(string response)
        {
            if (Regex.IsMatch(response.Trim(),
                @"!" +
                @"(?<device_category>\d)" +
                @"ECN" +
                @"(?<model_name>[^/]*)/" +
                @"(?<iscp_port>\d{5})/" +
                @"(?<area_code>\w{2})/" +
                @"(?<identifier>.*)"
            ) == false)
            {
                throw new Exception("Invalid discovery response");
            }
            // Return string looks something like this:
            // !1ECNTX-NR609/60128/DX
            GroupCollection info = Regex.Match(response.Trim(),
                @"!" +
                @"(?<device_category>\d)" +
                @"ECN" +
                @"(?<model_name>[^/]*)/" +
                @"(?<iscp_port>\d{5})/" +
                @"(?<area_code>\w{2})/" +
                @"(?<identifier>.*)"
            ).Groups;

            return new ReceiverInfo() {
                ModelName = info["model_name"].Value ?? "",
                Category = info["device_category"].Value ?? "",
                Port = Int32.Parse(info["iscp_port"].Value),
                AreaCode = info["area_code"].Value ?? "",
                Identifier = info["identifier"].Value ?? ""
            };
        }
    }

}