using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_FriendLinkDAL: BaseDAL<S_FriendLink>, IS_FriendLinkDAL
    {
        public void Trans1() {//事务
            using (var db = new LFTHWDBModel())
            {
                using (var tran = new TransactionScope())   //开启事务
                {
                    var friendLik = db.S_FriendLink.FirstOrDefault(s => s.ID == 1);
                    db.S_FriendLink.Remove(friendLik); 
                    db.SaveChanges();

                    tran.Complete();  //必须调用.Complete()，不然数据不会保存
                }   //出了using代码块如果还没调用Complete()，所有操作就会自动回滚
            }
        }

        public void Trans2()
        {
            using (var db = new LFTHWDBModel())
            {
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var friendLik = db.S_FriendLink.FirstOrDefault(s => s.ID == 1);
                    db.S_FriendLink.Remove(friendLik);  
                    db.SaveChanges();
                    tran.Commit();  //必须调用Commit()，不然数据不会保存
                }
                catch (Exception ex)
                {
                    tran.Rollback();    //出错就回滚
                }
            }
        }

        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var student = db.S_FriendLink.FirstOrDefault(s => s.ID == id);  
                db.S_FriendLink.Remove(student); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_FriendLink GetById(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var student = db.S_FriendLink.FirstOrDefault(s => s.ID == id);
                return student;
            }
        }

        public bool Update(S_FriendLink sFriendLink)
        {
            using (var db = new LFTHWDBModel())
            {
                var _sFriendLink = db.S_FriendLink.FirstOrDefault(s => s.ID == sFriendLink.ID);
                _sFriendLink.ShopID = sFriendLink.ShopID;

                return db.SaveChanges()>0? true :false;
            }
        }
    }
}
