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
    public class TripsBLL : BaseBLL<sline_line>, ITripsBLL
    {
        private readonly ITripsDAL _ITripsDAL;
        public TripsBLL()
            : base()
        {
            _ITripsDAL = new TripsDAL();
        }

        public List<TripListEntity> GetPage(TripQueryParam pageParam) {
            return _ITripsDAL.GetPage(pageParam).ToList<TripListEntity>();
        }
    }
}
