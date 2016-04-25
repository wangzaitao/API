using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pcategory")]
    public class PCategoryController : ApiController
        {
            readonly IP_CategoryBLL _IP_CategoryBLL;

            public PCategoryController(IP_CategoryBLL iP_CategoryBLL)
            {
                _IP_CategoryBLL = iP_CategoryBLL;
            }

            [Route("getall")]
            public List<P_Category> GetAll()
            {
                return _IP_CategoryBLL.GetAll();
            }

            [Route("getbyid")]
            public P_Category Get(int id)
            {
                return _IP_CategoryBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(P_Category pCategory)
            {
                _IP_CategoryBLL.Add(pCategory);
            }

            [Route("update")]
            public void PostEdit(P_Category pCategory)
            {
                _IP_CategoryBLL.Update(pCategory, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IP_CategoryBLL.Delete(id);
            }
        }
    }


