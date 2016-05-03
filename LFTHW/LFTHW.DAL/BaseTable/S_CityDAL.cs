using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_CityDAL : BaseDAL<S_City>, IS_CityDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sCity = db.S_City.FirstOrDefault(s => s.ID == id);  
                db.S_City.Remove(sCity); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_City GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sCity = db.S_City.FirstOrDefault(s => s.ID == id);
                return sCity;
            }
        }

        public bool Update(S_City sCity) {
            using (var db = new LFTHWDBModel())
            {
                var _sCity = db.S_City.FirstOrDefault(s => s.ID == sCity.ID);
                _sCity.ID = sCity.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
