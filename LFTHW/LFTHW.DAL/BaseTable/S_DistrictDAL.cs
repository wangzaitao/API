using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_DistrictDAL : BaseDAL<S_District>, IS_DistrictDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sDistrict = db.S_District.FirstOrDefault(s => s.ID == id);  
                db.S_District.Remove(sDistrict); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_District GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sDistrict = db.S_District.FirstOrDefault(s => s.ID == id);
                return sDistrict;
            }
        }

        public bool Update(S_District sDistrict) {
            using (var db = new LFTHWDBModel())
            {
                var _sDistrict = db.S_District.FirstOrDefault(s => s.ID == sDistrict.ID);
                _sDistrict.ID = sDistrict.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
