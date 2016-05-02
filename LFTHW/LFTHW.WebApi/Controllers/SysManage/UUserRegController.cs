using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uuserreg")]
    public class UUserRegController : ApiController
    {
        readonly IU_UserRegBLL _IU_UserRegBLL;

        public UUserRegController(IU_UserRegBLL iU_UserRegBLL)
        {
            _IU_UserRegBLL = iU_UserRegBLL;
        }

        [Route("getall")]
        public List<U_UserReg> GetAll()
        {
            return _IU_UserRegBLL.GetAll();
        }

        [Route("getbyid")]
        public U_UserReg Get(int id)
        {
            return _IU_UserRegBLL.GetById(id);
        }

        [Route("add")]
        public U_UserReg PostAdd(U_UserReg uUserReg)
        {
            return _IU_UserRegBLL.Add(uUserReg);
        }

        [Route("update")]
        public bool PostEdit(U_UserReg uUserReg)
        {
            return _IU_UserRegBLL.Update(uUserReg, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IU_UserRegBLL.Delete(id);
        }
    }
}


