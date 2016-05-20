using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEntity;

namespace BaseIBLL
{
    public interface UserIBLL
    {
        #region 存储过程
        //通过主键查询数据
        UserEntity GetBG_UserDataByPK(string id);

        //分页查询所有数据
        List<UserEntity> GetBG_UserDataByPage(string condition, int pageIndex, int pageSize, out int rCount, out int pCount);

        //按条件查询所有数据
        List<UserEntity> GetBG_UserDataByCondition(int recordNum, string orderColumn, string orderType, string condition);

        //通过Model添加数据
        int AddBG_UserDataByModel(UserEntity model);

        //通过Model修改数据
        int UpdateBG_UserDataByModel(UserEntity model);

        //通过主键删除数据
        int DeleteBG_UserDataByPK(string id);
        #endregion
    }
}
