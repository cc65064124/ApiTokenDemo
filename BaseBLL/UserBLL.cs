using BaseDAL;
using BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBLL
{
    public class UserBLL
    {
        UserDAL DAL = new UserDAL();
        #region 存储过程
        //通过主键查询数据
        public UserEntity GetBG_UserDataByPK(string id)
        {
            return DAL.GetBG_UserDataByPK(id);
        }

        //分页查询所有数据
        public List<UserEntity> GetBG_UserDataByPage(string condition, int pageIndex, int pageSize, out int rCount, out int pCount)
        {
            return DAL.GetBG_UserDataByPage(condition, pageIndex, pageSize, out rCount, out pCount);
        }

        //按条件查询所有数据
        public List<UserEntity> GetBG_UserDataByCondition(int recordNum, string orderColumn, string orderType, string condition)
        {
            return DAL.GetBG_UserDataByCondition(recordNum, orderColumn, orderType, condition);
        }

        //通过Model添加数据
        public int AddBG_UserDataByModel(UserEntity model)
        {
            return DAL.AddBG_UserDataByModel(model);
        }

        //通过Model修改数据
        public int UpdateBG_UserDataByModel(UserEntity model)
        {
            return DAL.UpdateBG_UserDataByModel(model);
        }

        //通过主键删除数据
        public int DeleteBG_UserDataByPK(string id)
        {
            return DAL.DeleteBG_UserDataByPK(id);
        }
        #endregion

    }
}
