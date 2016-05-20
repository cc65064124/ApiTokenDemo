using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBsaic.Toolkit
{
    public class FileStorage
    {
        public byte[] GetFileStream()
        {
            byte[] bytes =null;
            //获取文件路径
            var FileSource = LibConstant.SECUITY_STORE;
            //获取关联文件的后缀名
            //读取文件流
            FileStream fs = new FileStream(FileSource, FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            if (fs.Length > 0)
            {
                var byteFile = ToolDataConvert.StreamToBytes(fs);
                return byteFile;
            }
            return null;
        }
    }
}
