using System;
using System.Linq;
using LFTHW.IDAL;
using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.DAL
{
    public class P_PictureDAL : BaseDAL<P_Picture>, IP_PictureDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pPicture = db.P_Picture.FirstOrDefault(s => s.ID == id);
                db.P_Picture.Remove(pPicture);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public IQueryable<P_Picture> GetByPdtID(long pdtID)
        {
            var db = new LFTHWDBModel();
            var pPicture = db.P_Picture.Where<P_Picture>(s => s.PdtID == pdtID);
            return pPicture;
        }

        public bool Update(P_Picture pPicture)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pPicture = db.P_Picture.FirstOrDefault(s => s.ID == pPicture.ID);
                _pPicture.ID = pPicture.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(List<P_Picture> pPictureList, long pdtID)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var rList = db.P_Picture.Where(r => r.PdtID == pdtID);
                    foreach (var r in rList)
                    {
                        db.P_Picture.Remove(r);
                    }

                    foreach (var picture in pPictureList)
                    {
                        db.P_Picture.Add(picture);
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
