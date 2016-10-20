using LTHW.DAL.Mysql;
using LTHW.IBLL.Mysql;
using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.BLL.Mysql
{
    public class NotesBLL : BaseBLL<sline_notes>, INotesBLL
    {
        private readonly INotesDAL _INotesDAL;
        public NotesBLL()
            : base()
        {
            _INotesDAL = new NotesDAL();
        }

        public List<sline_notes> GetPage(NotesQueryParams pageParam)
        {
            return _INotesDAL.GetPage(pageParam).ToList<sline_notes>();
        }

        public sline_notes GetById(int id)
        {
            return _INotesDAL.GetById(id);
        }
    }
}
