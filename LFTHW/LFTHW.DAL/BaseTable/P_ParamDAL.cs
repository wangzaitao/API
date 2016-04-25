using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_ParamDAL : BaseDAL<P_Param>, IP_ParamDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pParam = db.P_Param.FirstOrDefault(s => s.ID == id);  
                db.P_Param.Remove(pParam); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Param GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pParam = db.P_Param.FirstOrDefault(s => s.ID == id);
                return pParam;
            }
        }

        public bool Update(P_Param pParam) {
            using (var db = new LFTHWDBModel())
            {
                var _pParam = db.P_Param.FirstOrDefault(s => s.ID == pParam.ID);
                _pParam.ID = pParam.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
