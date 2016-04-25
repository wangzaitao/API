using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_PdtInfoDAL : BaseDAL<P_PdtInfo>, IP_PdtInfoDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == id);  
                db.P_PdtInfo.Remove(pPdtInfo); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_PdtInfo GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == id);
                return pPdtInfo;
            }
        }

        public bool Update(P_PdtInfo pPdtInfo) {
            using (var db = new LFTHWDBModel())
            {
                var _pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == pPdtInfo.PdtID);
                _pPdtInfo.PdtID = pPdtInfo.PdtID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
