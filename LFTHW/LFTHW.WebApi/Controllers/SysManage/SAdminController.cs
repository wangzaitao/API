using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;
using System;

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
        public S_Admin PostAdd(S_Admin sAdmin)
        {
            try
            {
                return _IS_AdminBLL.Add(sAdmin);
            }
            catch (Exception ex) {
                var msg = ex.Message;
                return null;
            }
        }

        [Route("update")]
        public bool PostEdit(S_Admin sAdmin)
        {
            return _IS_AdminBLL.Update(sAdmin, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_AdminBLL.Delete(id);
        }
    }
}


