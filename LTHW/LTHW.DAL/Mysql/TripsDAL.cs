using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using LTHW.Utility;

namespace LTHW.DAL.Mysql
{
    public class TripsDAL : BaseDAL<sline_line>, ITripsDAL
    {

        public IQueryable<TripListEntity> GetPage(TripQueryParam pageParam)
        {
            var db = new LTHWMysqlModel();
            var trips = from a in db.sline_line
                        select new TripListEntity
                        {
                            isjian = a.isjian,
                            istejia = a.istejia,
                            id = a.id,
                            attrid = a.attrid,
                            kindlist = a.kindlist,
                            lineday = a.lineday,
                            litpic = a.litpic,
                            storeprice = a.storeprice,
                            title = a.title,
                            modtime = a.modtime
                        };

            if (pageParam.isjian >= 0)
            {
                trips = trips.Where(p => p.isjian == pageParam.isjian);
            }

            if (pageParam.istejia >= 0)
            {
                trips = trips.Where(p => p.istejia == pageParam.istejia);
            }

            if (!string.IsNullOrEmpty(pageParam.kindlist))
            {
                trips = trips.Where(p => p.kindlist.Split(',').Contains(pageParam.kindlist));
            }

            if (!string.IsNullOrEmpty(pageParam.attrid))
            {
                trips = trips.Where(p => p.attrid.Split(',').Contains(pageParam.attrid));
            }

            pageParam.total = trips.Count();
            if (pageParam.isDesc)
                trips = trips.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                //trips = trips.OrderBy<TripListEntity>("modtime").Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            else
                trips = trips.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            return trips;
        }
    }
}
