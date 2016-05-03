using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_ProvinceDAL : BaseDAL<S_Province>, IS_ProvinceDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sProvince = db.S_Province.FirstOrDefault(s => s.ID == id);  
                db.S_Province.Remove(sProvince); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_Province GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sProvince = db.S_Province.FirstOrDefault(s => s.ID == id);
                return sProvince;
            }
        }

        public bool Update(S_Province sProvince) {
            using (var db = new LFTHWDBModel())
            {
                var _sProvince = db.S_Province.FirstOrDefault(s => s.ID == sProvince.ID);
                _sProvince.ID = sProvince.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
