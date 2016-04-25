using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_PictureDAL : BaseDAL<P_Picture>, IP_PictureDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPicture = db.P_Picture.FirstOrDefault(s => s.ID == id);  
                db.P_Picture.Remove(pPicture); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Picture GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPicture = db.P_Picture.FirstOrDefault(s => s.ID == id);
                return pPicture;
            }
        }

        public bool Update(P_Picture pPicture) {
            using (var db = new LFTHWDBModel())
            {
                var _pPicture = db.P_Picture.FirstOrDefault(s => s.ID == pPicture.ID);
                _pPicture.ID = pPicture.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
