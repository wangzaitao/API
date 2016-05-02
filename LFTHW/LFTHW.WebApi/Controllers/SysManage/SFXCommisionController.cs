using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/sfxcommision")]
    public class SFXCommisionController : ApiController
    {
        readonly IS_FXCommisionBLL _IS_FXCommisionBLL;

        public SFXCommisionController(IS_FXCommisionBLL iS_FXCommisionBLL)
        {
            _IS_FXCommisionBLL = iS_FXCommisionBLL;
        }

        [Route("getall")]
        public List<S_FXCommision> GetAll()
        {
            return _IS_FXCommisionBLL.GetAll();
        }

        [Route("getbyid")]
        public S_FXCommision Get(int id)
        {
            return _IS_FXCommisionBLL.GetById(id);
        }

        [Route("add")]
        public S_FXCommision PostAdd(S_FXCommision sFXCommision)
        {
            return _IS_FXCommisionBLL.Add(sFXCommision);
        }

        [Route("update")]
        public bool PostEdit(S_FXCommision sFXCommision)
        {
            return _IS_FXCommisionBLL.Update(sFXCommision, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_FXCommisionBLL.Delete(id);
        }
    }
}


