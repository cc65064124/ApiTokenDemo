using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEntity
{
    /// <summary>
    /// UserEntity
    /// </summary>
    [Serializable]
    public partial class UserEntity
    {
        #region Model

        /// <summary>
        /// 用户id
        /// </summary>
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
