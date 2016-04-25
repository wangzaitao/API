using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/sdistrict")]
    public class SDistrictController : ApiController
        {
            readonly IS_DistrictBLL _IS_DistrictBLL;

            public SDistrictController(IS_DistrictBLL iS_DistrictBLL)
            {
                _IS_DistrictBLL = iS_DistrictBLL;
            }

            [Route("getall")]
            public List<S_District> GetAll()
            {
                return _IS_DistrictBLL.GetAll();
            }

            [Route("getbyid")]
            public S_District Get(int id)
            {
                return _IS_DistrictBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(S_District sDistrict)
            {
                _IS_DistrictBLL.Add(sDistrict);
            }

            [Route("update")]
            public void PostEdit(S_District sDistrict)
            {
                _IS_DistrictBLL.Update(sDistrict, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IS_DistrictBLL.Delete(id);
            }
        }
    }


