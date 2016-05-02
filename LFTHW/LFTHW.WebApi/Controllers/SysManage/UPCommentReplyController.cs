using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/upcommentreply")]
    public class UPCommentReplyController : ApiController
    {
        readonly IUP_CommentReplyBLL _IUP_CommentReplyBLL;

        public UPCommentReplyController(IUP_CommentReplyBLL iUP_CommentReplyBLL)
        {
            _IUP_CommentReplyBLL = iUP_CommentReplyBLL;
        }

        [Route("getall")]
        public List<UP_CommentReply> GetAll()
        {
            return _IUP_CommentReplyBLL.GetAll();
        }

        [Route("getbyid")]
        public UP_CommentReply Get(int id)
        {
            return _IUP_CommentReplyBLL.GetById(id);
        }

        [Route("add")]
        public UP_CommentReply PostAdd(UP_CommentReply upCommentReply)
        {
            return _IUP_CommentReplyBLL.Add(upCommentReply);
        }

        [Route("update")]
        public bool PostEdit(UP_CommentReply upCommentReply)
        {
            return _IUP_CommentReplyBLL.Update(upCommentReply, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IUP_CommentReplyBLL.Delete(id);
        }
    }
}


