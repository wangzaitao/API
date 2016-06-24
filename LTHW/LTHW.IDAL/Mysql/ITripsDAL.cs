using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface ITripsDAL : IBaseDAL<sline_line>
    {
        IQueryable<TripListEntity> GetPage(TripQueryParam pageParam);

        TripInfoEntity GetById(int id);
    }
}
