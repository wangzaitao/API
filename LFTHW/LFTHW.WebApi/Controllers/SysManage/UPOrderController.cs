using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uporder")]
    public class UPOrderController : ApiController
        {
            readonly IUP_OrderBLL _IUP_OrderBLL;

            public UPOrderController(IUP_OrderBLL iUP_OrderBLL)
            {
                _IUP_OrderBLL = iUP_OrderBLL;
            }

            [Route("getall")]
            public List<UP_Order> GetAll()
            {
                return _IUP_OrderBLL.GetAll();
            }

            [Route("getbyid")]
            public UP_Order Get(int id)
            {
                return _IUP_OrderBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(UP_Order upOrder)
            {
                _IUP_OrderBLL.Add(upOrder);
            }

            [Route("update")]
            public void PostEdit(UP_Order upOrder)
            {
                _IUP_OrderBLL.Update(upOrder, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IUP_OrderBLL.Delete(id);
            }
        }
    }


