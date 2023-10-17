using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    internal class NetworkUtils
    {
        public static List<IPAddress> GetAllBroadcastAddresses()
        {
            List<IPAddress> broadcastAddresses = new List<IPAddress>();

            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in nic.GetIPProperties().UnicastAddresses.Where(uAddress => 
                    uAddress.Address.AddressFamily == AddressFamily.InterNetwork 
                    && uAddress.IPv4Mask != null
                    && uAddress.Address.GetAddressBytes()[0] != 169
                    ).Distinct())
                {
                    broadcastAddresses.Add(CreateBroadcastAddress(unicastIPAddressInformation));
                }
            }

            return broadcastAddresses;
        }

        private static IPAddress CreateBroadcastAddress(UnicastIPAddressInformation uAddress)
        {
            int ipAddress = BitConverter.ToInt32(uAddress.Address.GetAddressBytes(), 0);
            int subnet = BitConverter.ToInt32(uAddress.IPv4Mask.GetAddressBytes(), 0);
            int broadcast = ipAddress | ~subnet;

            return new IPAddress(BitConverter.GetBytes(broadcast));
        }

    }
}
