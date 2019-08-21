using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Anchorage.Server.Models
{
    public class Author
    {

        public static string GenerateAuthorId(string hostAddress,string boardKey)
        {
            using (var alg = SHA512.Create())
            {
                var data = alg.ComputeHash(Encoding.UTF8.GetBytes(hostAddress + "-" + DateTimeOffset.Now.ToString("yyyy/MM/dd") + "-" + boardKey));
                return Convert.ToBase64String(data).Replace("+", "").Replace("=", "").Replace("/", "").Remove(9);
            }
        }
    }
}
