using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/upcart")]
    public class UPCartController : ApiController
    {
        readonly IUP_CartBLL _IUP_CartBLL;

        public UPCartController(IUP_CartBLL iUP_CartBLL)
        {
            _IUP_CartBLL = iUP_CartBLL;
        }

        [Route("getall")]
        public List<UP_Cart> GetAll()
        {
            return _IUP_CartBLL.GetAll();
        }

        [Route("getbyid")]
        public UP_Cart Get(int id)
        {
            return _IUP_CartBLL.GetById(id);
        }

        [Route("add")]
        public UP_Cart PostAdd(UP_Cart upCart)
        {
            return _IUP_CartBLL.Add(upCart);
        }

        [Route("update")]
        public bool PostEdit(UP_Cart upCart)
        {
            return _IUP_CartBLL.Update(upCart, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IUP_CartBLL.Delete(id);
        }
    }
}


