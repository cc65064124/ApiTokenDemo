using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsBsaic.Toolkit
{
    public class JsonHelper
    {
        private JsonHelper()
        {
        }

        /// <summary>
        /// 进行拼接
        /// </summary>
        /// <param name="dictionary"></param>
        public void SerializeObject(IReadOnlyDictionary<string, string> dictionary)
        {
            StringBuilder jsonStringBuilder = new StringBuilder();
            if (dictionary.Count > 0)
            {
                foreach (var key in dictionary)
                {
                    if (key.Value.StartsWith("{"))
                    {
                        jsonStringBuilder.AppendFormat("\"{0}\"\":{1},", key.Key, key.Value);
                    }
                    else
                    {
                        jsonStringBuilder.AppendFormat("\"{0}\"\":{1}\"", key.Key, key.Value);
                    }
                }
            }
        }

        /// <summary>
        /// 序列化为JObject
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static JObject DeserializeJObject(string jsonString)
        {
            return (JObject)JsonConvert.SerializeObject(jsonString);
        }

        /// <summary>
        /// 序列化Jarray
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static JArray DeserializeJarray(string jsonString)
        {
          return   new JArray(jsonString);
        }
    }
}
