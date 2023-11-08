using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Eiscp.Core.Interfaces;
using System.Text.RegularExpressions;
using Eiscp.Core.Models;

namespace Eiscp.Core
{
    public class NetworkUtils
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

        /// <summary>
        /// Try to find ISCP devices on network.
        /// </summary>
        /// Waits for <paramref name="timeout"/> seconds, then returns all devices found,
        /// in form of a list of <see cref="IReceiver"/>s.        
        public static List<ReceiverInfo> Discover(double timeout)
        {
            int onkyoPort = 60128;
            byte[] onkyoMagic = (new EISCPPacket("!xECNQSTN")).Bytes;

            var receivers = new List<ReceiverInfo>();


            foreach (IPAddress broadcastAddress in NetworkUtils.GetAllBroadcastAddresses())
            {
                // Broadcast magic
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                using (socket)
                {
                    socket.Blocking = false; // So we can use Poll
                    socket.EnableBroadcast = true;
                    socket.Bind(new IPEndPoint(IPAddress.Any, 0));
                    socket.SendTo(onkyoMagic, new IPEndPoint(broadcastAddress, onkyoPort));

                    EndPoint addr = new IPEndPoint(IPAddress.Broadcast, onkyoPort);
                    byte[] data = new byte[1024];
                    int read = 0;
                    while (true)
                    {
                        int microsecondTimeout = (int)(timeout * 1000000);
                        if (!socket.Poll(microsecondTimeout, SelectMode.SelectRead))
                        {
                            break;
                        }
                        read = socket.ReceiveFrom(data, ref addr);

                        
                        string response = Encoding.ASCII.GetString(EISCPPacket.Parse(data));

                        receivers.Add(ReceiverInfo.ParseDiscoveryResponse((addr as IPEndPoint), response));
                        
                    }
                }
            }

            return receivers;
        }

    }
}
