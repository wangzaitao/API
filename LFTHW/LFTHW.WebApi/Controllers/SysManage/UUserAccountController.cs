using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uuseraccount")]
    public class UUserAccountController : ApiController
        {
            readonly IU_UserAccountBLL _IU_UserAccountBLL;

            public UUserAccountController(IU_UserAccountBLL iU_UserAccountBLL)
            {
                _IU_UserAccountBLL = iU_UserAccountBLL;
            }

            [Route("getall")]
            public List<U_UserAccount> GetAll()
            {
                return _IU_UserAccountBLL.GetAll();
            }

            [Route("getbyid")]
            public U_UserAccount Get(int id)
            {
                return _IU_UserAccountBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(U_UserAccount uUserAccount)
            {
                _IU_UserAccountBLL.Add(uUserAccount);
            }

            [Route("update")]
            public void PostEdit(U_UserAccount uUserAccount)
            {
                _IU_UserAccountBLL.Update(uUserAccount, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IU_UserAccountBLL.Delete(id);
            }
        }
    }


