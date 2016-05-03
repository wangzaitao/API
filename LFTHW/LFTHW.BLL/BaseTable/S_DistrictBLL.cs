using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_DistrictBLL : BaseBLL<S_District>, IS_DistrictBLL
    {
        private readonly IS_DistrictDAL _IS_DistrictDAL;
        public S_DistrictBLL()
            : base()
        {
            _IS_DistrictDAL = new S_DistrictDAL();
        }

        public bool Delete(int id) {
            return _IS_DistrictDAL.Delete(id);
        }

        public S_District GetById(int id)
        {
            return _IS_DistrictDAL.GetById(id);
        }
        public bool Update(S_District sDistrict)
        {
            return _IS_DistrictDAL.Update(sDistrict);
        }
    }
}

