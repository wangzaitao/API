using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/sprovince")]
    public class SProvinceController : ApiController
        {
            readonly IS_ProvinceBLL _IS_ProvinceBLL;

            public SProvinceController(IS_ProvinceBLL iS_ProvinceBLL)
            {
                _IS_ProvinceBLL = iS_ProvinceBLL;
            }

            [Route("getall")]
            public List<S_Province> GetAll()
            {
                return _IS_ProvinceBLL.GetAll();
            }

            [Route("getbyid")]
            public S_Province Get(int id)
            {
                return _IS_ProvinceBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(S_Province sProvince)
            {
                _IS_ProvinceBLL.Add(sProvince);
            }

            [Route("update")]
            public void PostEdit(S_Province sProvince)
            {
                _IS_ProvinceBLL.Update(sProvince, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IS_ProvinceBLL.Delete(id);
            }
        }
    }


