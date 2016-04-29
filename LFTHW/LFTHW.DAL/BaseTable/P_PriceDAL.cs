using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.DAL
{
    public class P_PriceDAL : BaseDAL<P_Price>, IP_PriceDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPrice = db.P_Price.FirstOrDefault(s => s.ID == id);  
                db.P_Price.Remove(pPrice); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Price GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPrice = db.P_Price.FirstOrDefault(s => s.ID == id);
                return pPrice;
            }
        }

        public bool Update(P_Price pPrice) {
            using (var db = new LFTHWDBModel())
            {
                var _pPrice = db.P_Price.FirstOrDefault(s => s.ID == pPrice.ID);
                _pPrice.ID = pPrice.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(List<P_Price> pPriceList, long pdtID)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var rList = db.P_Price.Where(r => r.PdtID == pdtID);
                    foreach (var r in rList)
                    {
                        db.P_Price.Remove(r);
                    }

                    foreach (var picture in pPriceList)
                    {
                        db.P_Price.Add(picture);
                    }

                    res = db.SaveChanges();

                    tran.Commit();  //必须调用Commit()，不然数据不会保存
                }
                catch (Exception ex)
                {
                    tran.Rollback();    //出错就回滚
                }


                return res > 0 ? true : false;
            }
        }
    }
}
