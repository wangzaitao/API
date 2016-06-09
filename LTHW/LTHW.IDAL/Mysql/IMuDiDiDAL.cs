using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface IMuDiDiDAL : IBaseDAL<sline_destinations>
    {
        List<sline_destinations> GetTree(long pid);
    }
}
