using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uporderdetail")]
    public class UPOrderDetailController : ApiController
    {
        readonly IUP_OrderDetailBLL _IUP_OrderDetailBLL;

        public UPOrderDetailController(IUP_OrderDetailBLL iUP_OrderDetailBLL)
        {
            _IUP_OrderDetailBLL = iUP_OrderDetailBLL;
        }

        [Route("getall")]
        public List<UP_OrderDetail> GetAll()
        {
            return _IUP_OrderDetailBLL.GetAll();
        }

        [Route("getbyid")]
        public UP_OrderDetail Get(int id)
        {
            return _IUP_OrderDetailBLL.GetById(id);
        }

        [Route("add")]
        public UP_OrderDetail PostAdd(UP_OrderDetail upOrderDetail)
        {
            return _IUP_OrderDetailBLL.Add(upOrderDetail);
        }

        [Route("update")]
        public bool PostEdit(UP_OrderDetail upOrderDetail)
        {
            return _IUP_OrderDetailBLL.Update(upOrderDetail, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IUP_OrderDetailBLL.Delete(id);
        }
    }
}


