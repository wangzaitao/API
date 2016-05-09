using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pprice")]
    public class PPriceController : ApiController
    {
        readonly IP_PriceBLL _IP_PriceBLL;

        public PPriceController(IP_PriceBLL iP_PriceBLL)
        {
            _IP_PriceBLL = iP_PriceBLL;
        }

        [Route("getall")]
        public List<P_Price> GetAll()
        {
            return _IP_PriceBLL.GetAll();
        }

        [Route("getbypdtid")]
        public List<P_Price> Get(int pdtID)
        {
            return _IP_PriceBLL.GetByPdtID(pdtID);
        }

        [Route("add")]
        public P_Price PostAdd(P_Price pPrice)
        {
            return _IP_PriceBLL.Add(pPrice);
        }

        [Route("edit")]
        public bool PostEdit(List<P_Price> pPriceList)
        {
            return _IP_PriceBLL.Edit(pPriceList);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_PriceBLL.Delete(id);
        }
    }
}


