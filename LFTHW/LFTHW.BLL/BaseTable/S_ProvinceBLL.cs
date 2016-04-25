using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_ProvinceBLL : BaseBLL<S_Province>, IS_ProvinceBLL
    {
        private readonly IS_ProvinceDAL _IS_ProvinceDAL;
        public S_ProvinceBLL()
            : base()
        {
            _IS_ProvinceDAL = new S_ProvinceDAL();
        }

        public bool Delete(int id) {
            return _IS_ProvinceDAL.Delete(id);
        }

        public S_Province GetById(int id)
        {
            return _IS_ProvinceDAL.GetById(id);
        }
        public bool Update(S_Province sProvince)
        {
            return _IS_ProvinceDAL.Update(sProvince);
        }
    }
}

