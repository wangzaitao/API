using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface INotesDAL : IBaseDAL<sline_notes>
    {
        IQueryable<sline_notes> GetPage(NotesQueryParams pageParam);

        sline_notes GetById(int id);
    }
}
