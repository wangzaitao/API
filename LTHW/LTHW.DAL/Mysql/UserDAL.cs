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
                        from = string.IsNullOrEmpty(wxUserInfoEntity.from) ? "wx" : wxUserInfoEntity.from,//wx
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

        /// <summary>
        /// 根据会员id或者微信openid获取会员信息
        /// </summary>
        /// <param name="mid"></param>
        /// <param name="openid"></param>
        /// <returns></returns>
        public UserInfoEntity GetUserInfo(int mid, string openid)
        {
            using (var db = new LTHWMysqlModel())
            {
                var userInfo = new UserInfoEntity();


                if (mid > 0)
                {
                    var users = from u in db.sline_member where u.mid == mid select u;
                    userInfo.UserInfo = users.FirstOrDefault();

                    var opens = from t in db.sline_member_third
                                where t.mid == mid && t.@from == "wx"
                                select t;
                    userInfo.OpenUserInfo = opens.FirstOrDefault();
                }
                else
                {
                    var opens = from t in db.sline_member_third
                                where t.openid == openid
                                select t;
                    userInfo.OpenUserInfo = opens.FirstOrDefault();
                    var users = from u in db.sline_member where u.mid == userInfo.OpenUserInfo.mid select u;
                    userInfo.UserInfo = users.FirstOrDefault();
                }

                return userInfo;
            }
        }

        /// <summary>
        /// 根据会员id获取分销关联上下级
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public FenxiaoGuanlianUsersEntity GetFenxiaoGuanlianUsers(int mid)
        {
            using (var db = new LTHWMysqlModel())
            {
                var fxglUserInfo = new FenxiaoGuanlianUsersEntity();

                var users = from u in db.sline_member where u.mid == mid select u;
                var user = users.FirstOrDefault();

                if (user != null && !string.IsNullOrEmpty(user.pid))
                {
                    var arrPid = user.pid.Split(',');
                    var s_users = from u in db.sline_member
                                  where (arrPid.Length > 0 && u.mid == int.Parse(arrPid[0]))|| (arrPid.Length > 1 && u.mid == int.Parse(arrPid[1]))
                                  || (arrPid.Length > 2 && u.mid == int.Parse(arrPid[2]))|| (arrPid.Length > 3 && u.mid == int.Parse(arrPid[3]))
                                  || (arrPid.Length > 4 && u.mid == int.Parse(arrPid[4]))
                                  select u;

                    //fxglUserInfo.SuperiorUsers = s_users.ToList<sline_member>();
                }

                //var opens = from t in db.sline_member_third
                //            where t.mid == mid && t.@from == "wx"
                //            select t;
                //userInfo.OpenUserInfo = opens.FirstOrDefault();

                return fxglUserInfo;
            }
        }
    }
}
