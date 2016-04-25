using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/friendlink")]
    public class SFriendLinkController : ApiController
    {
        readonly IS_FriendLinkBLL _IS_FriendLinkBLL;

        public SFriendLinkController(IS_FriendLinkBLL iS_FriendLinkBLL)
        {
            _IS_FriendLinkBLL = iS_FriendLinkBLL;
        }

        [Route("getall")]
        public List<S_FriendLink> GetAll()
        {
            return _IS_FriendLinkBLL.GetAll();
        }

        [Route("getbyid")]
        public S_FriendLink Get(int id)
        {
            return _IS_FriendLinkBLL.GetById(id);
        }

        [Route("add")]
        public void PostAdd(S_FriendLink friendLink)
        {
            _IS_FriendLinkBLL.Add(friendLink);
        }

        [Route("update")]
        public void PostUpdate(S_FriendLink friendLink)
        {
            _IS_FriendLinkBLL.Update(friendLink,null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_FriendLinkBLL.Delete(id);
        }
    }
}
