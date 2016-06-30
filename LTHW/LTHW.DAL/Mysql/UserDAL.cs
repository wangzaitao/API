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
        public int EditWeixinUser(WXUserInfoEntity wxUserInfoEntity)
        {
            using (var db = new LTHWMysqlModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var t_member = db.sline_member_third.FirstOrDefault(m => m.openid == wxUserInfoEntity.openid);
                    if (t_member != null && t_member.openid == wxUserInfoEntity.openid)
                    {//已添加到数据库
                        t_member.headimgurl = wxUserInfoEntity.headimgurl;
                        t_member.status = wxUserInfoEntity.status;
                        if (t_member.status == 1)
                        {//关注时修改
                            t_member.nickname = wxUserInfoEntity.nickname;
                            t_member.headimgurl = wxUserInfoEntity.headimgurl;
                            t_member.subscribetime = wxUserInfoEntity.subscribetime;
                        }
                        else
                        {//取消关注时修改
                            t_member.unsubscribetime = wxUserInfoEntity.unsubscribetime;
                        }

                        db.SaveChanges();
                    }
                    else
                    {
                        if (wxUserInfoEntity.status == 0)
                        {//如果没加入到数据库，并且是取消关注时，直接返回
                            return 1;
                        }

                        var member = new sline_member
                        {
                            nickname = wxUserInfoEntity.nickname,
                            pwd = wxUserInfoEntity.pwd,
                            connectid = wxUserInfoEntity.openid,
                            from = string.IsNullOrEmpty(wxUserInfoEntity.from) ? "wx" : wxUserInfoEntity.from,//wx
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
                        db.SaveChanges();
                        res = member.mid;

                        var member_third = new sline_member_third
                        {
                            mid = res,
                            from = string.IsNullOrEmpty(wxUserInfoEntity.from) ? "wx" : wxUserInfoEntity.from,//wx
                            nickname = wxUserInfoEntity.nickname,
                            openid = wxUserInfoEntity.openid,
                            headimgurl = wxUserInfoEntity.headimgurl,
                            status = wxUserInfoEntity.status,
                            subscribetime = wxUserInfoEntity.subscribetime
                        };

                        db.sline_member_third.Add(member_third);
                        db.SaveChanges();
                    }

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
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <param name="openid"></param>
        /// <returns></returns>
        public UserInfoEntity GetUserInfo(int mid, string thirdfrom, string openid)
        {
            using (var db = new LTHWMysqlModel())
            {
                var userInfo = new UserInfoEntity();

                if (mid > 0)
                {
                    var users = from u in db.sline_member
                                join t in db.sline_member_third on u.mid equals t.mid into temp
                                from tt in temp.DefaultIfEmpty()
                                where u.mid == mid
                                select new UserInfoEntity
                                {
                                    mid = u.mid,
                                    checkmail = u.checkmail,
                                    checkphone = u.checkphone,
                                    province = u.province,
                                    city = u.city,
                                    cardid = u.cardid,
                                    address = u.address,
                                    postcode = u.postcode,
                                    connectid = u.connectid,
                                    email = u.email,
                                    @from = u.@from,
                                    jifen = u.jifen,
                                    joinip = u.joinip,
                                    jointime = u.jointime,
                                    litpic = u.litpic,
                                    loginip = u.loginip,
                                    logintime = u.logintime,
                                    mobile = u.mobile,
                                    money = u.money,
                                    mtype = u.mtype,
                                    nickname = u.nickname,
                                    openid = tt == null ? "" : tt.openid,
                                    wxfrom = tt == null ? "" : tt.@from,
                                    wxnickname = tt == null ? "" : tt.nickname,
                                    pid = u.pid,
                                    pwd = u.pwd,
                                    rank = u.rank,
                                    regtype = u.regtype,
                                    remarks = u.remarks,
                                    safeanswer = u.safeanswer,
                                    safequestion = u.safequestion,
                                    sex = u.sex,
                                    truename = u.truename
                                };
                    if (!string.IsNullOrEmpty(thirdfrom))
                    {
                        users = users.Where(u => u.wxfrom == thirdfrom);
                    }
                    userInfo = users.FirstOrDefault();
                }
                if (mid == 0 && !string.IsNullOrEmpty(openid))
                {
                    var opens = from u in db.sline_member
                                from t in db.sline_member_third
                                where u.mid == t.mid && t.openid == openid
                                select new UserInfoEntity
                                {
                                    mid = u.mid,
                                    checkmail = u.checkmail,
                                    checkphone = u.checkphone,
                                    province = u.province,
                                    city = u.city,
                                    cardid = u.cardid,
                                    address = u.address,
                                    postcode = u.postcode,
                                    connectid = u.connectid,
                                    email = u.email,
                                    @from = u.@from,
                                    jifen = u.jifen,
                                    joinip = u.joinip,
                                    jointime = u.jointime,
                                    litpic = u.litpic,
                                    loginip = u.loginip,
                                    logintime = u.logintime,
                                    mobile = u.mobile,
                                    money = u.money,
                                    mtype = u.mtype,
                                    nickname = u.nickname,
                                    openid = t.openid,
                                    wxfrom = t.@from,
                                    wxnickname = t.nickname,
                                    pid = u.pid,
                                    pwd = u.pwd,
                                    rank = u.rank,
                                    regtype = u.regtype,
                                    remarks = u.remarks,
                                    safeanswer = u.safeanswer,
                                    safequestion = u.safequestion,
                                    sex = u.sex,
                                    truename = u.truename
                                };
                    userInfo = opens.FirstOrDefault();
                }

                return userInfo;
            }
        }

        /// <summary>
        /// 根据会员id获取分销关联上下级
        /// </summary>
        /// <param name="mid"></param>
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <returns></returns>
        public FenxiaoGuanlianUsersEntity GetFenxiaoGuanlianUsers(int mid, string thirdfrom)
        {
            using (var db = new LTHWMysqlModel())
            {
                var fxglUserInfo = new FenxiaoGuanlianUsersEntity();

                var user = db.sline_member.FirstOrDefault(u => u.mid == mid);

                if (user != null && !string.IsNullOrEmpty(user.pid))
                {
                    //取前五名
                    var arrPid = user.pid.Split(',');
                    int firstpid = arrPid.Length > 0 ? int.Parse(arrPid[0]) : 0,
                        secondpid = arrPid.Length > 1 ? int.Parse(arrPid[1]) : 0,
                        thirdpid = arrPid.Length > 2 ? int.Parse(arrPid[2]) : 0,
                        forthpid = arrPid.Length > 3 ? int.Parse(arrPid[3]) : 0,
                        fifthpid = arrPid.Length > 4 ? int.Parse(arrPid[4]) : 0;
                    var s_users = from u in db.sline_member
                                  join t in db.sline_member_third on u.mid equals t.mid into temp
                                  from tt in temp.DefaultIfEmpty()
                                  where (u.mid == firstpid || u.mid == secondpid || u.mid == thirdpid || u.mid == forthpid || u.mid == fifthpid)
                                  select new UserInfoEntity
                                  {
                                      mid = u.mid,
                                      checkmail = u.checkmail,
                                      checkphone = u.checkphone,
                                      province = u.province,
                                      city = u.city,
                                      cardid = u.cardid,
                                      address = u.address,
                                      postcode = u.postcode,
                                      connectid = u.connectid,
                                      email = u.email,
                                      @from = u.@from,
                                      jifen = u.jifen,
                                      joinip = u.joinip,
                                      jointime = u.jointime,
                                      litpic = u.litpic,
                                      loginip = u.loginip,
                                      logintime = u.logintime,
                                      mobile = u.mobile,
                                      money = u.money,
                                      mtype = u.mtype,
                                      nickname = u.nickname,
                                      openid = tt == null ? "" : tt.openid,
                                      wxfrom = tt == null ? "" : tt.@from,
                                      wxnickname = tt == null ? "" : tt.nickname,
                                      pid = u.pid,
                                      pwd = u.pwd,
                                      rank = u.rank,
                                      regtype = u.regtype,
                                      remarks = u.remarks,
                                      safeanswer = u.safeanswer,
                                      safequestion = u.safequestion,
                                      sex = u.sex,
                                      truename = u.truename
                                  };
                    if (!string.IsNullOrEmpty(thirdfrom))
                    {
                        s_users = s_users.Where(u => u.wxfrom == thirdfrom);
                    }
                    fxglUserInfo.SuperiorUsers = s_users.ToList<UserInfoEntity>();
                }

                fxglUserInfo.JuniorUsers = GetUserInfoListByPid(mid.ToString(), thirdfrom);

                return fxglUserInfo;
            }
        }

        /// <summary>
        /// 根据传入的mid，用pid条件查询
        /// </summary>
        /// <param name="mid_pid">!string.isNullOrEmtpy(pid)?(mid+","+pid):mid</param>
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <returns></returns>
        public List<UserInfoEntity> GetUserInfoListByPid(string mid_pid, string thirdfrom)
        {
            using (var db = new LTHWMysqlModel())
            {
                var users = from u in db.sline_member
                            join t in db.sline_member_third on u.mid equals t.mid into temp
                            from tt in temp.DefaultIfEmpty()
                            where ("-" + u.pid).Contains("-" + mid_pid)
                            select new UserInfoEntity
                            {
                                mid = u.mid,
                                checkmail = u.checkmail,
                                checkphone = u.checkphone,
                                province = u.province,
                                city = u.city,
                                cardid = u.cardid,
                                address = u.address,
                                postcode = u.postcode,
                                connectid = u.connectid,
                                email = u.email,
                                @from = u.@from,
                                jifen = u.jifen,
                                joinip = u.joinip,
                                jointime = u.jointime,
                                litpic = u.litpic,
                                loginip = u.loginip,
                                logintime = u.logintime,
                                mobile = u.mobile,
                                money = u.money,
                                mtype = u.mtype,
                                nickname = u.nickname,
                                openid = tt == null ? "" : tt.openid,
                                wxfrom = tt == null ? "" : tt.@from,
                                wxnickname = tt == null ? "" : tt.nickname,
                                pid = u.pid,
                                pwd = u.pwd,
                                rank = u.rank,
                                regtype = u.regtype,
                                remarks = u.remarks,
                                safeanswer = u.safeanswer,
                                safequestion = u.safequestion,
                                sex = u.sex,
                                truename = u.truename
                            };

                if (!string.IsNullOrEmpty(thirdfrom))
                {
                    users = users.Where(u => u.wxfrom == thirdfrom);
                }
                return users.ToList<UserInfoEntity>();
            }
        }
    }
}
