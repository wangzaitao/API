using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface INotesBLL : IBaseBLL<sline_notes>
    {
        List<sline_notes> GetPage(NotesQueryParams pageParam);

        sline_notes GetById(int id);
    }
}
