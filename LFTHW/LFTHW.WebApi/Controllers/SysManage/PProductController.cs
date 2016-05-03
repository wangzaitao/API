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
        public CategoryProduct Get(int id)
        {
            return _IP_ProductBLL.GetById(id);
        }

        [Route("postbywhere")]
        public List<CategoryProduct> PostByWhere(PdtQueryParam pdtParam)
        {
            return _IP_ProductBLL.GetByWhere(pdtParam);
        }

        [Route("add")]
        public P_Product PostAdd(P_Product pProduct)
        {
            return _IP_ProductBLL.Add(pProduct);
        }

        [Route("edit")]
        public bool PostEdit(ProductBasicInfo product)
        {
            return _IP_ProductBLL.Edit(product);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_ProductBLL.Delete(id);
        }
    }
}


