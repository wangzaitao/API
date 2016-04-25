using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_ParamGroupDAL : BaseDAL<P_ParamGroup>, IP_ParamGroupDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pParamGroup = db.P_ParamGroup.FirstOrDefault(s => s.ID == id);  
                db.P_ParamGroup.Remove(pParamGroup); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_ParamGroup GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pParamGroup = db.P_ParamGroup.FirstOrDefault(s => s.ID == id);
                return pParamGroup;
            }
        }

        public bool Update(P_ParamGroup pParamGroup) {
            using (var db = new LFTHWDBModel())
            {
                var _pParamGroup = db.P_ParamGroup.FirstOrDefault(s => s.ID == pParamGroup.ID);
                _pParamGroup.ID = pParamGroup.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
