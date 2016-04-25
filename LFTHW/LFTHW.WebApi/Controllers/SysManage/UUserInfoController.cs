using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uuserinfo")]
    public class UUserInfoController : ApiController
        {
            readonly IU_UserInfoBLL _IU_UserInfoBLL;

            public UUserInfoController(IU_UserInfoBLL iU_UserInfoBLL)
            {
                _IU_UserInfoBLL = iU_UserInfoBLL;
            }

            [Route("getall")]
            public List<U_UserInfo> GetAll()
            {
                return _IU_UserInfoBLL.GetAll();
            }

            [Route("getbyid")]
            public U_UserInfo Get(int id)
            {
                return _IU_UserInfoBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(U_UserInfo uUserInfo)
            {
                _IU_UserInfoBLL.Add(uUserInfo);
            }

            [Route("update")]
            public void PostEdit(U_UserInfo uUserInfo)
            {
                _IU_UserInfoBLL.Update(uUserInfo, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IU_UserInfoBLL.Delete(id);
            }
        }
    }


