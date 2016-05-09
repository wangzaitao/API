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

        [Route("getbypdtid")]
        public List<P_Picture> Get(int pdtID)
        {
            return _IP_PictureBLL.GetByPdtID(pdtID);
        }

        [Route("add")]
        public P_Picture PostAdd(P_Picture pPicture)
        {
            return _IP_PictureBLL.Add(pPicture);
        }

        [Route("edit")]
        public bool PostEdit(List<P_Picture> pPictureList)
        {
            return _IP_PictureBLL.Edit(pPictureList);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_PictureBLL.Delete(id);
        }
    }
}


