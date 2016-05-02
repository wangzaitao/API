using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/snotice")]
    public class SNoticeController : ApiController
    {
        readonly IS_NoticeBLL _IS_NoticeBLL;

        public SNoticeController(IS_NoticeBLL iS_NoticeBLL)
        {
            _IS_NoticeBLL = iS_NoticeBLL;
        }

        [Route("getall")]
        public List<S_Notice> GetAll()
        {
            return _IS_NoticeBLL.GetAll();
        }

        [Route("getbyid")]
        public S_Notice Get(int id)
        {
            return _IS_NoticeBLL.GetById(id);
        }

        [Route("add")]
        public S_Notice PostAdd(S_Notice sNotice)
        {
            return _IS_NoticeBLL.Add(sNotice);
        }

        [Route("update")]
        public bool PostEdit(S_Notice sNotice)
        {
            return _IS_NoticeBLL.Update(sNotice, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_NoticeBLL.Delete(id);
        }
    }
}


