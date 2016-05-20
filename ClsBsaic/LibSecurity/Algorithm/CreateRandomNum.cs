using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBsaic.LibSecurity
{
    public static class CreateRandomNum
    {
        private static string strCreatTime;

        public static string CraetToken()
        {
            var time = DateTime.UtcNow.ToFileTime().ToString();
            //生成随机数
            //var random = Guid.NewGuid().ToString("N");
            byte[] byteBuffer = Guid.NewGuid().ToByteArray();
            var intGuid =BitConverter.ToInt64(byteBuffer, 0).ToString();
            // 获取随机数+时间的MD5 小写
            var createToken = SecurityMD5.GetStringMD5toUnicode(intGuid + time).ToLower();
            return createToken;
        }
    }
}
