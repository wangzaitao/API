using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_UserConsumeBLL : BaseBLL<UP_UserConsume>, IUP_UserConsumeBLL
    {
        private readonly IUP_UserConsumeDAL _IUP_UserConsumeDAL;
        public UP_UserConsumeBLL()
            : base()
        {
            _IUP_UserConsumeDAL = new UP_UserConsumeDAL();
        }

        public bool Delete(int id) {
            return _IUP_UserConsumeDAL.Delete(id);
        }

        public UP_UserConsume GetById(int id)
        {
            return _IUP_UserConsumeDAL.GetById(id);
        }
        public bool Update(UP_UserConsume upUserConsume)
        {
            return _IUP_UserConsumeDAL.Update(upUserConsume);
        }
    }
}

