using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_AdminBLL : BaseBLL<S_Admin>, IS_AdminBLL
    {
        private readonly IS_AdminDAL _IS_AdminDAL;
        public S_AdminBLL()
            : base()
        {
            _IS_AdminDAL = new S_AdminDAL();
        }

        public bool Delete(int id) {
            return _IS_AdminDAL.Delete(id);
        }

        public S_Admin GetById(int id)
        {
            return _IS_AdminDAL.GetById(id);
        }
        public bool Update(S_Admin sAdmin)
        {
            return _IS_AdminDAL.Update(sAdmin);
        }
    }
}

