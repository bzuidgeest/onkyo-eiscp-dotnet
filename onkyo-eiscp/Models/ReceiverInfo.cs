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
        public string Category { get; private set; } = string.Empty;
        public string ModelName { get; private set; } = string.Empty;
        public int Port { get; private set; } = 0;

        public IPEndPoint IPEndPoint { get; private set; }

        public string SerialPortName { get; private set; } = string.Empty;


        public string Hostname { get; private set; }

        public string AreaCode { get; private set; } = string.Empty;

        public string Identifier { get; private set; } = string.Empty;
        public ReceiverInfo(IPEndPoint iPEndPoint, string modelName, string category, int port, string areaCode, string identifier) 
        {
            (IPEndPoint, ModelName, Category, Port, AreaCode, Identifier) = (iPEndPoint, modelName, category, port, areaCode, identifier);

        }

        public ReceiverInfo(string serialPortName, string modelName, string category, int port, string areaCode, string identifier)
        {
            (SerialPortName, ModelName, Category, Port, AreaCode, Identifier) = (serialPortName, modelName, category, port, areaCode, identifier);

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
                @"(?<identifier>[0-9A-Fa-f]{12})"
            ) == false)
            {
                throw new Exception("Invalid discovery response");
            }


            // !(?<device_category>\d)ECN(?<model_name>[^/]*)/(?<iscp_port>\d{5})/(?<area_code>\w{2})/(?<identifier>[0-9A-Fa-f]{12})
            // My guess is that identifier is basically the mac address of the receiver. Adjusted expression accordingly
            // Return string looks something like this:
            // !1ECNTX-NR609/60128/DX/000000000000
            GroupCollection info = Regex.Match(response.Trim(),
                @"!" +
                @"(?<device_category>\d)" +
                @"ECN" +
                @"(?<model_name>[^/]*)/" +
                @"(?<iscp_port>\d{5})/" +
                @"(?<area_code>\w{2})/" +
                @"(?<identifier>[0-9A-Fa-f]{12})"
            ).Groups;



            return new ReceiverInfo(
                iPEndPoint,
                info["model_name"].Value ?? string.Empty,
                info["device_category"].Value ?? string.Empty,
                Int32.Parse(info["iscp_port"].Value),
                info["area_code"].Value ?? string.Empty,
                info["identifier"].Value ?? string.Empty
            );
        }
    }

}