using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBsaic.Toolkit
{
  public  class ToolDataConvert
    {
        #region  Hex 转换 byte 
        /// <summary>
        /// hex to byte
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>System.Byte[][].</returns>
        public static byte[] HexToBytes(string src)
        {
            int legth = src.Length / 2;
            byte[] arr = new byte[legth];
            for (int i = 0; i < legth; i++)
            {
                arr[i] = Convert.ToByte(src.Substring(i * 2, 2), 16);
            }
            return arr;
        }

        /// <summary>
        /// byte to Hex (字母小写)
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>System.String.</returns>
        public static string ByteToHex(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte by in bytes)
            {
                hex.AppendFormat("{0:X2}", by);
            }
            return hex.ToString();
        }
        #endregion

        #region stream 与byte转换

        #endregion
        /// <summary>
        /// stream转换Bytes
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Byte[][].</returns>
        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            //设置当前流位置
            // byte[] data = new byte[READBUF_SIZE];
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }

        /// <summary>
        /// Bytes转换stream
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>Stream.</returns>
        public static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

    }
}
