using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBsaic.LibSecurity
{
    public class SecurityBase64
    {
        /// <summary>
        /// UTF8 string to byte 64编码
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        public static string EncodeToBase64String(string data)
        {
            try
            {
                byte[] bytes = null;
                Encoding encode = Encoding.UTF8;
                bytes = encode.GetBytes(data);
                return Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// string to string 64解码
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.Byte[][].</returns>
        public static byte[] DecodeStringBase64(string data)
        {
            try
            {
                byte[] bytes = null;
                return bytes = Convert.FromBase64String(data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
