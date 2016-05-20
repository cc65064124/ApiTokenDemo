using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsBsaic.LibSecurity.Algorithm.securitylocal;
using System.IO;

namespace ClsBsaic.LibSecurity
{
  public  class SecurityMD5
    {
        private  SecurityMD5()
        {
        }
        /// <summary>
        /// 获取字符串的MD5.
        /// </summary>
        /// <param name="str">需要计算的内容.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] GetStringMD5ToByte(string str)
        {
            MD5 md = MD5.Create();
            byte[] bytes = md.ComputeHash(Encoding.UTF8.GetBytes(str));
            return bytes;
        }
        /// <summary>
        /// 32 字符的十六进制格式哈希字符串的任何 MD5 哈希函数.
        /// </summary>
        /// <param name="str">需要计算的内容.</param>
        /// <returns>System.String.</returns>
        public static string GetStringMD5toUnicode(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(bytes);
            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return sbuild.ToString().Substring(8, 16);
        }

        /// <summary>
        /// 32 字符的十六进制格式哈希字符串的任何 MD5 哈希函数.
        /// </summary>
        /// <param name="bytes">需要计算的内容.</param>
        /// <returns>System.String.</returns>
        public static string GetByteMD5ToHex(byte[] bytes)
        {
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(bytes);
            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return sbuild.ToString().Substring(8, 16);
        }

        /// <summary>
        /// 获取字节数组的MD5.
        /// </summary>
        /// <param name="bytes">需要计算的内容.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] GetByteMD5ToBytes(byte[] bytes)
        {
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(bytes);
            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return Encoding.UTF8.GetBytes(sbuild.ToString());
        }

        /// <summary>
        /// 获取流的MD5.
        /// </summary>
        /// <param name="stream">需要计算的stream.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] GetStreamMD5ToByte(Stream stream)
        {
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(stream);

            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return Encoding.UTF8.GetBytes(sbuild.ToString());
        }

        /// <summary>
        /// Gets the hash by stream automatic string.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>System.String.</returns>
        public static string GetStreamMD5ToString(Stream stream)
        {
            stream.Position = 0;
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(stream);
            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return sbuild.ToString();
        }

        /// <summary>
        /// 获取流的MD5.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] GetHashByStream(Stream stream)
        {
            MD5 md = MD5.Create();
            byte[] bt = md.ComputeHash(stream);

            StringBuilder sbuild = new StringBuilder();
            for (int i = 0; i < bt.Length; i++)
            {
                sbuild.Append(bt[i].ToString("x2"));
            }
            return Encoding.UTF8.GetBytes(sbuild.ToString());
        }
    }
}
