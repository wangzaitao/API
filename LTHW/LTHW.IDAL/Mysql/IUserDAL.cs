using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface IUserDAL : IBaseDAL<sline_member>
    {
        int AddWeixinUser(WXUserInfoEntity wxUserInfoEntity);

        UserInfoEntity GetUserInfo(int mid, string openid);

        FenxiaoGuanlianUsersEntity GetFenxiaoGuanlianUsers(int mid);
    }
}
