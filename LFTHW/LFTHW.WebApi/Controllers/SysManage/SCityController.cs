using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/scity")]
    public class SCityController : ApiController
    {
        readonly IS_CityBLL _IS_CityBLL;

        public SCityController(IS_CityBLL iS_CityBLL)
        {
            _IS_CityBLL = iS_CityBLL;
        }

        [Route("getall")]
        public List<S_City> GetAll()
        {
            return _IS_CityBLL.GetAll();
        }

        [Route("getbyid")]
        public S_City Get(int id)
        {
            return _IS_CityBLL.GetById(id);
        }

        [Route("add")]
        public S_City PostAdd(S_City sCity)
        {
            return _IS_CityBLL.Add(sCity);
        }

        [Route("update")]
        public bool PostEdit(S_City sCity)
        {
            return _IS_CityBLL.Update(sCity, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_CityBLL.Delete(id);
        }
    }
}


