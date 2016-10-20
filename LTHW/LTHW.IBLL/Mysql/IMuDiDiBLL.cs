using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface IMuDiDiBLL : IBaseBLL<sline_destinations>
    {
        List<TreeObject> GetTree(long pid);
    }
}
