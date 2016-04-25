using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_FXCommisionDAL : BaseDAL<S_FXCommision>, IS_FXCommisionDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sFXCommision = db.S_FXCommision.FirstOrDefault(s => s.ID == id);  
                db.S_FXCommision.Remove(sFXCommision); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_FXCommision GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sFXCommision = db.S_FXCommision.FirstOrDefault(s => s.ID == id);
                return sFXCommision;
            }
        }

        public bool Update(S_FXCommision sFXCommision) {
            using (var db = new LFTHWDBModel())
            {
                var _sFXCommision = db.S_FXCommision.FirstOrDefault(s => s.ID == sFXCommision.ID);
                _sFXCommision.ID = sFXCommision.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
