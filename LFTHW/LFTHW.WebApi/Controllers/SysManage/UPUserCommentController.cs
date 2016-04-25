using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/upusercomment")]
    public class UPUserCommentController : ApiController
        {
            readonly IUP_UserCommentBLL _IUP_UserCommentBLL;

            public UPUserCommentController(IUP_UserCommentBLL iUP_UserCommentBLL)
            {
                _IUP_UserCommentBLL = iUP_UserCommentBLL;
            }

            [Route("getall")]
            public List<UP_UserComment> GetAll()
            {
                return _IUP_UserCommentBLL.GetAll();
            }

            [Route("getbyid")]
            public UP_UserComment Get(int id)
            {
                return _IUP_UserCommentBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(UP_UserComment upUserComment)
            {
                _IUP_UserCommentBLL.Add(upUserComment);
            }

            [Route("update")]
            public void PostEdit(UP_UserComment upUserComment)
            {
                _IUP_UserCommentBLL.Update(upUserComment, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IUP_UserCommentBLL.Delete(id);
            }
        }
    }


