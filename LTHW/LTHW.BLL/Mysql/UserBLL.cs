using LTHW.DAL.Mysql;
using LTHW.IBLL.Mysql;
using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.BLL.Mysql
{
    public class UserBLL: BaseBLL<sline_member>,IUserBLL
    {
        private readonly IUserDAL _IUserDAL;
        public UserBLL()
            : base()
        {
            _IUserDAL = new UserDAL();
        }

        public int AddWeixinUser(WXUserInfoEntity wxUserInfoEntity) {
            return _IUserDAL.AddWeixinUser(wxUserInfoEntity);
        }
    }
}
