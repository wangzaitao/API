using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/sadmin")]
    public class SAdminController : ApiController
        {
            readonly IS_AdminBLL _IS_AdminBLL;

            public SAdminController(IS_AdminBLL iS_AdminBLL)
            {
                _IS_AdminBLL = iS_AdminBLL;
            }

            [Route("getall")]
            public List<S_Admin> GetAll()
            {
                return _IS_AdminBLL.GetAll();
            }

            [Route("getbyid")]
            public S_Admin Get(int id)
            {
                return _IS_AdminBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(S_Admin sAdmin)
            {
                _IS_AdminBLL.Add(sAdmin);
            }

            [Route("update")]
            public void PostEdit(S_Admin sAdmin)
            {
                _IS_AdminBLL.Update(sAdmin, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IS_AdminBLL.Delete(id);
            }
        }
    }


