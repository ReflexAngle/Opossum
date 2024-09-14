using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace opossum.Hashing
{
    public class hashToMD5
    {
        public static string computerMD5(string hello)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(hello);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte i in hashBytes) { sb.Append(i.ToString("X2")); }

                return sb.ToString();
            }
        }
    }
}
