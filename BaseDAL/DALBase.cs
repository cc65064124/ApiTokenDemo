using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace ClothingWorld.BackgroundDAL
{
    /// <summary>
    /// DAL基类层
    /// 创建时间：2015-11-19
    /// </summary>

    [Serializable]
    public class DALBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        private string _connectionStrings = null;
        public DALBase()
        {
            if (ConfigurationManager.ConnectionStrings["DBConnection"] != null)
            {
                _connectionStrings = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            }
        }
        public SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(_connectionStrings);
                return connection;
            }
        }
    }
}
