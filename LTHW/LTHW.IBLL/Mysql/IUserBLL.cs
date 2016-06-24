using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface IUserBLL: IBaseBLL<sline_member>
    {
        int AddWeixinUser(WXUserInfoEntity wxUserInfoEntity);

        UserInfoEntity GetUserInfo(int mid, string thirdfrom, string openid);
        FenxiaoGuanlianUsersEntity GetFenxiaoGuanlianUsers(int mid, string thirdfrom);

        List<UserInfoEntity> GetUserInfoListByPid(string mid_pid, string thirdfrom);
    }
}
