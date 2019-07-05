using Microsoft.AspNetCore.Http;
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
        public static string GetHostName(ConnectionInfo connectionInfo)
        {
            try
            {
                var ip = connectionInfo.RemoteIpAddress.MapToIPv4().ToString();
               
                return ip;

            }
            catch (SocketException)
            {
                return null;
            }
        }
    }
}
