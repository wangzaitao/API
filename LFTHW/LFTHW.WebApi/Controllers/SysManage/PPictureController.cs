using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ppicture")]
    public class PPictureController : ApiController
        {
            readonly IP_PictureBLL _IP_PictureBLL;

            public PPictureController(IP_PictureBLL iP_PictureBLL)
            {
                _IP_PictureBLL = iP_PictureBLL;
            }

            [Route("getall")]
            public List<P_Picture> GetAll()
            {
                return _IP_PictureBLL.GetAll();
            }

            [Route("getbyid")]
            public P_Picture Get(int id)
            {
                return _IP_PictureBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(P_Picture pPicture)
            {
                _IP_PictureBLL.Add(pPicture);
            }

            [Route("update")]
            public void PostEdit(P_Picture pPicture)
            {
                _IP_PictureBLL.Update(pPicture, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IP_PictureBLL.Delete(id);
            }
        }
    }


