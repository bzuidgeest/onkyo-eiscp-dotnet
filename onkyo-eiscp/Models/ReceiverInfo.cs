using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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

        public IPEndPoint IPEndPoint { get; private set; }

        public string Hostname { get; private set; }

        public string AreaCode { get; private set; } = "";

        public string Identifier { get; private set; } = "";
        private ReceiverInfo(IPEndPoint iPEndPoint, string modelName, string category, int port, string areaCode, string identifier) 
        {
            (IPEndPoint, ModelName, Category, Port, AreaCode, Identifier) = (iPEndPoint, modelName, category, port, areaCode, identifier);

        }  

        public static ReceiverInfo ParseDiscoveryResponse(IPEndPoint iPEndPoint, string response)
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

            return new ReceiverInfo(
                iPEndPoint,
                info["model_name"].Value ?? "",
                info["device_category"].Value ?? "",
                Int32.Parse(info["iscp_port"].Value),
                info["area_code"].Value ?? "",
                info["identifier"].Value ?? ""
            );
        }
    }

}