using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Anchorage.Server.Controllers.Common
{
    public class IpManager
    {
        public static string GetHostName()
        {
            try
            {
                var ip = Dns.GetHostEntry(Dns.GetHostName());
                return ip.AddressList[0].ToString();
            }
            catch (SocketException)
            {
                return null;
            }
        }
    }
}
