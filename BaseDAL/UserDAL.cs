using BaseEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDAL
{
   public class UserDAL
    {
        #region 存储过程
     
        /// <summary>
        /// 通过主键查询数据
        /// </summary>
        ///<param name='id'>主键ID</param>
        public UserEntity GetBG_UserDataByPK(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int)
                };
                parameters[0].Value = id;
                return SqlDataReaderToModel(DbHelperSQL.RunProcedure("[sp_GetBG_UserDataByPK]", parameters));
            }
            else
            {
                return null;
            };
        }

        /// <summary>
        /// 分页查询所有数据
        /// </summary>
        ///<param name='condition'>查询条件 and 1=1</param>
        ///<param name='pageIndex'>第几页</param>
        ///<param name='pageSize'>每页显示多少行</param>
        ///<param name='rCount'>总共有多少行</param>
        ///<param name='pCount'>总共有多少页</param>
        public List<UserEntity> GetBG_UserDataByPage(string condition, int pageIndex, int pageSize, out int rCount, out int pCount)
        {
            SqlParameter[] parameters = {
            new SqlParameter("@condition", SqlDbType.VarChar),
            new SqlParameter("@pageIndex", SqlDbType.Int),
            new SqlParameter("@pageSize", SqlDbType.Int),
            new SqlParameter("@rCount", SqlDbType.Int),
            new SqlParameter("@pCount", SqlDbType.Int)
            };
            parameters[0].Value = condition;
            parameters[1].Value = pageIndex;
            parameters[2].Value = pageSize;
            parameters[3].Direction = ParameterDirection.Output;
            parameters[4].Direction = ParameterDirection.Output;
            return SqlDataReaderToModelList(DbHelperSQL.RunProcedure("[sp_GetBG_UserDataByPage]", parameters), pageSize, out rCount, out pCount);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        ///<param name='recordNum'>查询多少条，等于0时查询所有</param>
        ///<param name='orderColumn'>排序的列，空时不排序</param>
        ///<param name='orderType'>排序类型正序或倒序</param>
        ///<param name='condition'>查询条件如:1=1</param>
        public List<UserEntity> GetBG_UserDataByCondition(int recordNum, string orderColumn, string orderType, string condition)
        {
            SqlParameter[] parameters = {
            new SqlParameter("@recordNum", SqlDbType.Int),
            new SqlParameter("@orderColumn", SqlDbType.VarChar),
            new SqlParameter("@orderType", SqlDbType.VarChar),
            new SqlParameter("@condition", SqlDbType.VarChar),
            };
            parameters[0].Value = recordNum;
            parameters[1].Value = orderColumn;
            parameters[2].Value = orderType;
            parameters[3].Value = condition;
            return SqlDataReaderToModelList(DbHelperSQL.RunProcedure("[sp_GetBG_UserDataByCondition]", parameters));
        }

        /// <summary>
        /// 通过Model添加数据
        /// </summary>
        ///<param name='model'>实体</param>
        public int AddBG_UserDataByModel(UserEntity model)
        {
            SqlParameter[] parameters = {
            new SqlParameter("@StrUserName", SqlDbType.NVarChar),
            new SqlParameter("@StrPassWord", SqlDbType.NVarChar),
            new SqlParameter("@IsEnable", SqlDbType.Bit)
            };
            parameters[0].Value = model.StrUserName;
            parameters[1].Value = model.StrPassWord;
            parameters[2].Value = model.IsEnable;

            return DbHelperSQL.RunProcedureGetAffectedCount("[sp_AddBG_UserDataByModel]", parameters);
        }

        /// <summary>
        /// 通过Model修改数据
        /// </summary>
        ///<param name='model'>实体</param>
        public int UpdateBG_UserDataByModel(UserEntity model)
        {
            SqlParameter[] parameters = {
            new SqlParameter("@Id", SqlDbType.Int),
            new SqlParameter("@StrUserName", SqlDbType.NVarChar),
            new SqlParameter("@StrPassWord", SqlDbType.NVarChar),
            new SqlParameter("@IsEnable", SqlDbType.Bit)
            };
            parameters[0].Value = model.Id;
            parameters[1].Value = model.StrUserName;
            parameters[2].Value = model.StrPassWord;
            parameters[3].Value = model.IsEnable;

            return DbHelperSQL.RunProcedureGetAffectedCount("[sp_UPDATEBG_UserDataByModel]", parameters);
        }

        /// <summary>
        /// 通过主键删除数据
        /// </summary>
        ///<param name='id'>主键ID</param>
        public int DeleteBG_UserDataByPK(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int)
                };
                parameters[0].Value = id;
                return DbHelperSQL.RunProcedureGetAffectedCount("[sp_DeleteBG_UserDataByPK]", parameters);
            }
            else
            {
                return 0;
            };
        }

        #region 被调用的方法
        //把DataSet转化成Model
        public UserEntity DataSetToMode(DataSet ds)
        {
            UserEntity model = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                #region
                DataRow dr = ds.Tables[0].Rows[0];
                model = new UserEntity();
                if (dr["Id"] != null)
                {
                    if (string.IsNullOrWhiteSpace(dr["Id"].ToString()))
                    {
                        model.Id = 0;
                    }
                    else
                    {
                        model.Id = int.Parse(dr["Id"].ToString());
                    }
                }
                if (dr["StrUserName"] != null)
                {
                    model.StrUserName = dr["StrUserName"].ToString();
                }
                if (dr["StrPassWord"] != null)
                {
                    model.StrPassWord = dr["StrPassWord"].ToString();
                }
                if (dr["IsEnable"] != null)
                {
                    if (string.IsNullOrWhiteSpace(dr["IsEnable"].ToString()))
                    {
                        model.IsEnable = null;
                    }
                    else
                    {
                        if (dr["IsEnable"].ToString() == "0" || dr["IsEnable"].ToString().ToLower() == "false")
                        {
                            model.IsEnable = false;
                        }
                        else if (dr["IsEnable"].ToString() == "1" || dr["IsEnable"].ToString().ToLower() == "true")
                        {
                            model.IsEnable = true;
                        }
                    }
                }

                #endregion
            }
            return model;
        }
        //把DataSet转化成ModelList
        public List<UserEntity> DataSetToModelList(DataSet ds)
        {
            List<UserEntity> lt = new List<UserEntity>();
            UserEntity model = null;
            if (ds != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    model = new UserEntity();
                    #region
                    if (dr["Id"] != null)
                    {
                        if (string.IsNullOrWhiteSpace(dr["Id"].ToString()))
                        {
                            model.Id = 0;
                        }
                        else
                        {
                            model.Id = int.Parse(dr["Id"].ToString());
                        }
                    }
                    if (dr["StrUserName"] != null)
                    {
                        model.StrUserName = dr["StrUserName"].ToString();
                    }
                    if (dr["StrPassWord"] != null)
                    {
                        model.StrPassWord = dr["StrPassWord"].ToString();
                    }
                    if (dr["IsEnable"] != null)
                    {
                        if (string.IsNullOrWhiteSpace(dr["IsEnable"].ToString()))
                        {
                            model.IsEnable = null;
                        }
                        else
                        {
                            if (dr["IsEnable"].ToString() == "0" || dr["IsEnable"].ToString().ToLower() == "false")
                            {
                                model.IsEnable = false;
                            }
                            else if (dr["IsEnable"].ToString() == "1" || dr["IsEnable"].ToString().ToLower() == "true")
                            {
                                model.IsEnable = true;
                            }
                        }
                    }

                    #endregion
                    lt.Add(model);
                }
            }
            return lt;
        }
        //把SqlDataReader转化成Model
        public UserEntity SqlDataReaderToModel(SqlDataReader reader)
        {
            UserEntity model = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    model = new UserEntity();
                    #region
                    if (reader.GetValue(0) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(0).ToString()))
                        {
                            model.Id = 0;
                        }
                        else
                        {
                            model.Id = int.Parse(reader.GetValue(0).ToString());
                        }
                    }
                    if (reader.GetValue(1) != null)
                    {
                        model.StrUserName = reader.GetValue(1).ToString();
                    }
                    if (reader.GetValue(2) != null)
                    {
                        model.StrPassWord = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(3) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(3).ToString()))
                        {
                            model.IsEnable = null;
                        }
                        else
                        {
                            if (reader.GetValue(3).ToString() == "0" || reader.GetValue(3).ToString().ToLower() == "false")
                            {
                                model.IsEnable = false;
                            }
                            else if (reader.GetValue(3).ToString() == "1" || reader.GetValue(3).ToString().ToLower() == "true")
                            {
                                model.IsEnable = true;
                            }
                        }
                    }

                    #endregion
                }
            }
            return model;
        }
        //把SqlDataReader转化成ModelList
        public List<UserEntity> SqlDataReaderToModelList(SqlDataReader reader)
        {
            List<UserEntity> lt = new List<UserEntity>();
            UserEntity model = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    model = new UserEntity();
                    #region
                    if (reader.GetValue(0) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(0).ToString()))
                        {
                            model.Id = 0;
                        }
                        else
                        {
                            model.Id = int.Parse(reader.GetValue(0).ToString());
                        }
                    }
                    if (reader.GetValue(1) != null)
                    {
                        model.StrUserName = reader.GetValue(1).ToString();
                    }
                    if (reader.GetValue(2) != null)
                    {
                        model.StrPassWord = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(3) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(3).ToString()))
                        {
                            model.IsEnable = null;
                        }
                        else
                        {
                            if (reader.GetValue(3).ToString() == "0" || reader.GetValue(3).ToString().ToLower() == "false")
                            {
                                model.IsEnable = false;
                            }
                            else if (reader.GetValue(3).ToString() == "1" || reader.GetValue(3).ToString().ToLower() == "true")
                            {
                                model.IsEnable = true;
                            }
                        }
                    }

                    #endregion
                    lt.Add(model);
                }
            }
            return lt;
        }
        //把SqlDataReader转化成ModelList支持分页
        public List<UserEntity> SqlDataReaderToModelList(SqlDataReader reader, int pageSize, out int rCount, out int pCount)
        {
            List<UserEntity> lt = new List<UserEntity>();
            UserEntity model = null;
            rCount = 0;
            pCount = 0;
            if (reader.HasRows)
            {
                int k = 0;
                while (reader.Read())
                {
                    k++;
                    model = new UserEntity();
                    #region
                    if (reader.GetValue(1) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(1).ToString()))
                        {
                            model.Id = 0;
                        }
                        else
                        {
                            model.Id = int.Parse(reader.GetValue(1).ToString());
                        }
                    }
                    if (reader.GetValue(2) != null)
                    {
                        model.StrUserName = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(3) != null)
                    {
                        model.StrPassWord = reader.GetValue(3).ToString();
                    }
                    if (reader.GetValue(4) != null)
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(4).ToString()))
                        {
                            model.IsEnable = null;
                        }
                        else
                        {
                            if (reader.GetValue(4).ToString() == "0" || reader.GetValue(4).ToString().ToLower() == "false")
                            {
                                model.IsEnable = false;
                            }
                            else if (reader.GetValue(4).ToString() == "1" || reader.GetValue(4).ToString().ToLower() == "true")
                            {
                                model.IsEnable = true;
                            }
                        }
                    }

                    #endregion
                    lt.Add(model);
                }
                rCount = k;
                pCount = (k + 1) / pageSize;
            }
            return lt;
        }
        #endregion
        #endregion 

        public void AddUser()
        { }

        public void UpdateUser()
        { }

        public void DeleteUser()
        { }

        public void SelectUserById()
        { }

        public void SelectUserByName()
        { }
    }
}
