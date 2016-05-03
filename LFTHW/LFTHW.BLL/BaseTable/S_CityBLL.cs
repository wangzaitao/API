using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_CityBLL : BaseBLL<S_City>, IS_CityBLL
    {
        private readonly IS_CityDAL _IS_CityDAL;
        public S_CityBLL()
            : base()
        {
            _IS_CityDAL = new S_CityDAL();
        }

        public bool Delete(int id) {
            return _IS_CityDAL.Delete(id);
        }

        public S_City GetById(int id)
        {
            return _IS_CityDAL.GetById(id);
        }
        public bool Update(S_City sCity)
        {
            return _IS_CityDAL.Update(sCity);
        }
    }
}

