using System;
using System.Runtime.Serialization;

namespace DataContract
{
    [DataContract]
    [Serializable]
    public class UserInfo
    {

        #region Model
        /// <summary>
        /// 用户id
        /// </summary>
        [DataMember]
        public int Id
        {
            set;
            get;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string StrUserName
        {
            set;
            get;
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string StrPassWord
        {
            set;
            get;
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool? IsEnable
        {
            set;
            get;
        }
        #endregion Model
    }
}
