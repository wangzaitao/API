using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_AdminDAL : BaseDAL<S_Admin>, IS_AdminDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sAdmin = db.S_Admin.FirstOrDefault(s => s.ID == id);  
                db.S_Admin.Remove(sAdmin); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_Admin GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sAdmin = db.S_Admin.FirstOrDefault(s => s.ID == id);
                return sAdmin;
            }
        }

        public bool Update(S_Admin sAdmin) {
            using (var db = new LFTHWDBModel())
            {
                var _sAdmin = db.S_Admin.FirstOrDefault(s => s.ID == sAdmin.ID);
                _sAdmin.ID = sAdmin.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
