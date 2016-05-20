using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClsBsaic.LibSecurity
{
    /// <summary>
    /// 3DES对称加密
    /// </summary>
    public class Security3DES
    {
        /// <summary>
        /// 3DES加密
        /// </summary>
        /// <param name="src">待加密的内容</param>
        /// <param name="key1">第一个密钥</param>
        /// <param name="key2">第二个密钥</param>
        /// <param name="key3">第三个密钥</param>
        /// <returns>System.Byte[][].</returns>
        /// <exception cref="CBException">3DES加密错误</exception>
        public static byte[] Encrypt(byte[] src, string key1, string key2, string key3)
        {
            byte[] result = null;
            if (src == null || src.Length < 1
                || key1 == null || key1.Length < 1
                || key2 == null || key2.Length < 1
                || key3 == null || key3.Length < 1)
            {
                //异常提示
            }
            if (key1.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key1.Length; i++)
                {
                    sb.Append("0");
                    key1 = key1 + sb.ToString();
                }
            }
            if (key2.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key2.Length; i++)
                {
                    sb.Append("0");
                    key2 = key2 + sb.ToString();
                }
            }
            if (key3.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key3.Length; i++)
                {
                    sb.Append("0");
                    key3 = key3 + sb.ToString();
                }
            }
            try
            {
                result = MainDecrypt(Encoding.UTF8.GetBytes(key1 + key2 + key3), src, true);
            }
            catch (Exception ex)
            {
                result = null;
                //Logger 异常提示
            }
            return result;
        }

        /// <summary>
        /// 3DES解密
        /// </summary>
        /// <param name="src">待解密的数据</param>
        /// <param name="key1">第一个密钥</param>
        /// <param name="key2">第二个密钥</param>
        /// <param name="key3">第三个密钥</param>
        /// <returns>System.Byte[][].</returns>
        /// <exception cref="CBException">3DES解密错误</exception>
        public static byte[] Decrypt(byte[] src, string key1, string key2, string key3)
        {
            byte[] result = null;
            if (src == null || src.Length < 1
                || key1 == null || key1.Length < 1
                || key2 == null || key2.Length < 1
                || key3 == null || key3.Length < 1)
            {
                //Logger 异常提示
            }
            if (key1.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key1.Length; i++)
                {
                    sb.Append("0");
                    key1 = key1 + sb.ToString();
                }
            }
            if (key2.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key2.Length; i++)
                {
                    sb.Append("0");
                    key2 = key2 + sb.ToString();
                }
            }
            if (key3.Length < 8)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - key3.Length; i++)
                {
                    sb.Append("0");
                    key3 = key3 + sb.ToString();
                }
            }
            try
            {
                result = MainDecrypt(Encoding.UTF8.GetBytes(key1 + key2 + key3), src, false);
            }
            catch (Exception ex)
            {
                result = null;
                //异常提示
                //throw new Exception(ex, "3DES解密错误"); ;
            }
            return result;
        }

        /// <summary>
        /// 对称加密加解密
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Neddby"></param>
        /// <param name="dere">False解密 True 加密</param>
        /// <returns></returns>
        private static byte[] MainDecrypt(byte[] Key, byte[] Neddby, bool dere)
        {
            var keyParam = new DesEdeParameters(Key);
            var engine = new PaddedBufferedBlockCipher(new DesEdeEngine());
            engine.Init(dere, keyParam);
            var data = engine.DoFinal(Neddby);
            return data;
        }

        /// <summary>
        /// 对称加密加解密
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Neddby"></param>
        /// <param name="dere">False解密 True 加密</param>
        /// <returns></returns>
        public static byte[] MainDecrypt(string strKey, string strNeddby, bool dere)
        {
            byte[] Key = Encoding.UTF8.GetBytes(strKey);
            byte[] Neddby = Encoding.UTF8.GetBytes(strNeddby);
            var keyParam = new DesEdeParameters(Key);
            var engine = new PaddedBufferedBlockCipher(new DesEdeEngine());
            engine.Init(dere, keyParam);
            var data = engine.DoFinal(Neddby);
            return data;
        }
    }
}
