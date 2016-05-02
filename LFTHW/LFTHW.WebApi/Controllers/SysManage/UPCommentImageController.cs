using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/upcommentimage")]
    public class UPCommentImageController : ApiController
    {
        readonly IUP_CommentImageBLL _IUP_CommentImageBLL;

        public UPCommentImageController(IUP_CommentImageBLL iUP_CommentImageBLL)
        {
            _IUP_CommentImageBLL = iUP_CommentImageBLL;
        }

        [Route("getall")]
        public List<UP_CommentImage> GetAll()
        {
            return _IUP_CommentImageBLL.GetAll();
        }

        [Route("getbyid")]
        public UP_CommentImage Get(int id)
        {
            return _IUP_CommentImageBLL.GetById(id);
        }

        [Route("add")]
        public UP_CommentImage PostAdd(UP_CommentImage upCommentImage)
        {
            return _IUP_CommentImageBLL.Add(upCommentImage);
        }

        [Route("update")]
        public bool PostEdit(UP_CommentImage upCommentImage)
        {
            return _IUP_CommentImageBLL.Update(upCommentImage, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IUP_CommentImageBLL.Delete(id);
        }
    }
}


