using LTHW.IDAL.Mysql;
using LTHW.Model;
using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class NotesDAL : BaseDAL<sline_notes>, INotesDAL
    {
        public IQueryable<sline_notes> GetPage(NotesQueryParams pageParam)
        {
            try
            {
                var db = new LTHWMysqlModel();
                var notes = from a in db.sline_notes
                            select a;

                if (!string.IsNullOrEmpty(pageParam.title))
                {
                    notes = notes.Where(p => p.title.Contains(pageParam.title));
                }

                if (pageParam.memberid > 0)
                {
                    notes = notes.Where(p => p.memberid == pageParam.memberid);
                }

                pageParam.total = notes.Count();

                if (pageParam.isDesc)
                    notes = notes.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    notes = notes.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);

                return notes;
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, ("文章：" + ex.Message + ex.InnerException.Message));
                return null;
            }
        }

        public sline_notes GetById(int id)
        {
            using (var db = new LTHWMysqlModel())
            {
                var notes = from a in db.sline_notes
                            where a.id == id
                            select a;
                return notes.FirstOrDefault();
            }
        }
    }
}
