using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pbrand")]
    public class PBrandController : ApiController
    {
        readonly IP_BrandBLL _IP_BrandBLL;

        public PBrandController(IP_BrandBLL iP_BrandBLL)
        {
            _IP_BrandBLL = iP_BrandBLL;
        }

        [Route("getall")]
        public List<P_Brand> GetAll()
        {
            return _IP_BrandBLL.GetAll();
        }

        [Route("getbyid")]
        public P_Brand Get(int id)
        {
            return _IP_BrandBLL.GetById(id);
        }

        [Route("add")]
        public P_Brand PostAdd(P_Brand pBrand)
        {
            return _IP_BrandBLL.Add(pBrand);
        }

        [Route("update")]
        public bool PostEdit(P_Brand pBrand)
        {
            return _IP_BrandBLL.Update(pBrand, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_BrandBLL.Delete(id);
        }
    }
}


