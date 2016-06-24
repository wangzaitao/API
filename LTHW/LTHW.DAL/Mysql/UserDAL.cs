using LTHW.IDAL.Mysql;
using LTHW.Model;
using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class UserDAL : BaseDAL<sline_member>, IUserDAL
    {
        /// <summary>
        /// 增加微信会员
        /// </summary>
        /// <param name="wxUserInfoEntity"></param>
        /// <returns>返回会员id</returns>
        public int AddWeixinUser(WXUserInfoEntity wxUserInfoEntity)
        {
            using (var db = new LTHWMysqlModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var member = new sline_member
                    {
                        nickname = wxUserInfoEntity.nickname,
                        pwd = wxUserInfoEntity.nickname
                    };
                    if (!string.IsNullOrEmpty(wxUserInfoEntity.recommendopenid))
                    {//有推荐人时，添加推荐人
                        var pusers = from u in db.sline_member
                                     from t in db.sline_member_third
                                     where u.mid == t.mid && t.openid == wxUserInfoEntity.recommendopenid
                                     select u;
                        var puser = pusers.FirstOrDefault();
                        if (puser != null)
                        {
                            member.pid = puser.mid.ToString() + (string.IsNullOrEmpty(puser.pid) ? "" : "," + puser.pid);
                        }
                    }

                    db.sline_member.Add(member);
                    res = db.SaveChanges();

                    var member_third = new sline_member_third
                    {
                        mid = res,
                        from = wxUserInfoEntity.from,
                        nickname = wxUserInfoEntity.nickname,
                        openid = wxUserInfoEntity.openid
                    };
                    db.sline_member.Add(member);
                    db.SaveChanges();

                    LogHelper.Info(this, "增加微信会员！");
                    tran.Commit();  //必须调用Commit()，不然数据不会保存
                }
                catch (Exception ex)
                {
                    tran.Rollback();    //出错就回滚
                    res = 0;
                    LogHelper.Error(this, ex.Message);
                }
                return res;
            }
        }
    }
}
