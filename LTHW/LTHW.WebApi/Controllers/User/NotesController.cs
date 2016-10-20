using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.User
{
    /// <summary>
    /// 会员游记维护
    /// </summary>
    [RoutePrefix("api/notes")]
    public class NotesController : ApiController
    {
        readonly INotesBLL _INotesBLL;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iNotesBLL"></param>
        public NotesController(INotesBLL iNotesBLL)
        {
            _INotesBLL = iNotesBLL;
        }

        /// <summary>
        /// 获取游记分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody<PageEntity<List<sline_notes>>> PostPage([FromBody]NotesQueryParams pageParam)
        {
            var list = _INotesBLL.GetPage(pageParam);
            return new ResponseBody<PageEntity<List<sline_notes>>> { Result = new PageEntity<List<sline_notes>> { data = list, total = pageParam.total }, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取游记详细信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>游记详细信息</returns>
        [Route("getbyid/{id}")]
        public ResponseBody<sline_notes> GetById(int id)
        {
            var info = _INotesBLL.GetById(id);
            return new ResponseBody<sline_notes> { Result = info, Code = "", Message = "" };
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [Route("delete")]
        public ResponseBody<bool> Delete(int id)
        {
            var userNotes = new sline_notes { id = id };
            var res = _INotesBLL.Delete(userNotes);
            return new ResponseBody<bool> { Result = res, Code = "", Message = "" };
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="notes">实体</param>
        /// <returns></returns>
        [Route("post")]
        public ResponseBody<bool> Post(sline_notes notes)
        {
            var res = false;
            if (notes.id > 0)
            {
                res = _INotesBLL.Add(notes);
            }
            else
            {
                var props = new string[] { "memberid", "title", "bannerpic", "litpic", "description", "content", "shownum", "modtime", "status", "reason", "displayorder", "issend", "kindlist", "finaldestid" };
                res = _INotesBLL.Update(notes, props);
            }
            return new ResponseBody<bool> { Result = res, Code = "", Message = "" };
        }
    }
}
