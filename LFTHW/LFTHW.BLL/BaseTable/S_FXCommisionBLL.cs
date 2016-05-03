using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_FXCommisionBLL : BaseBLL<S_FXCommision>, IS_FXCommisionBLL
    {
        private readonly IS_FXCommisionDAL _IS_FXCommisionDAL;
        public S_FXCommisionBLL()
            : base()
        {
            _IS_FXCommisionDAL = new S_FXCommisionDAL();
        }

        public bool Delete(int id) {
            return _IS_FXCommisionDAL.Delete(id);
        }

        public S_FXCommision GetById(int id)
        {
            return _IS_FXCommisionDAL.GetById(id);
        }
        public bool Update(S_FXCommision sFXCommision)
        {
            return _IS_FXCommisionDAL.Update(sFXCommision);
        }
    }
}

