using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pproduct")]
    public class PProductController : ApiController
        {
            readonly IP_ProductBLL _IP_ProductBLL;

            public PProductController(IP_ProductBLL iP_ProductBLL)
            {
                _IP_ProductBLL = iP_ProductBLL;
            }

            [Route("getall")]
            public List<P_Product> GetAll()
            {
                return _IP_ProductBLL.GetAll();
            }

            [Route("getbyid")]
            public P_Product Get(int id)
            {
                return _IP_ProductBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(P_Product pProduct)
            {
                _IP_ProductBLL.Add(pProduct);
            }

            [Route("update")]
            public void PostEdit(P_Product pProduct)
            {
                _IP_ProductBLL.Update(pProduct, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IP_ProductBLL.Delete(id);
            }
        }
    }


