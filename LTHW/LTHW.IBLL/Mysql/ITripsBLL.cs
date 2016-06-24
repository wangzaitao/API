using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface ITripsBLL : IBaseBLL<sline_line>
    {
        List<TripListEntity> GetPage(TripQueryParam pageParam);

        TripInfoEntity GetById(int id);
    }
}
