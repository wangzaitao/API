using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/upuserconsume")]
    public class UPUserConsumeController : ApiController
        {
            readonly IUP_UserConsumeBLL _IUP_UserConsumeBLL;

            public UPUserConsumeController(IUP_UserConsumeBLL iUP_UserConsumeBLL)
            {
                _IUP_UserConsumeBLL = iUP_UserConsumeBLL;
            }

            [Route("getall")]
            public List<UP_UserConsume> GetAll()
            {
                return _IUP_UserConsumeBLL.GetAll();
            }

            [Route("getbyid")]
            public UP_UserConsume Get(int id)
            {
                return _IUP_UserConsumeBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(UP_UserConsume upUserConsume)
            {
                _IUP_UserConsumeBLL.Add(upUserConsume);
            }

            [Route("update")]
            public void PostEdit(UP_UserConsume upUserConsume)
            {
                _IUP_UserConsumeBLL.Update(upUserConsume, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IUP_UserConsumeBLL.Delete(id);
            }
        }
    }


