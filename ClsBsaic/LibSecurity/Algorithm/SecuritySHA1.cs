using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClsBsaic.LibSecurity
{
   public class SecuritySHA1
    {
        /// <summary>
        /// 获取string SHA1 值
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.Byte</returns>
        public static byte[] GetHashByString(string data)
        {
           byte[] byteDate= Encoding.UTF8.GetBytes(data);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            return sha1.ComputeHash(byteDate);
        }
    }
}
