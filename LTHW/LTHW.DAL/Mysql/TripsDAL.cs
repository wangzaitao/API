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
        public TripInfoEntity getById(int id)
        {
            using (var db = new LTHWMysqlModel())
            {
                var tripInfo = new TripInfoEntity();

                var trips = from a in db.sline_line where a.id == id select a;
                tripInfo.Info = trips.FirstOrDefault();

                var contentList = from b in db.sline_line_jieshao
                                  where b.lineid == id
                                  select b;
                tripInfo.ContentList = contentList.ToList();

                if (tripInfo.Info != null)
                {
                    var kinds = tripInfo.Info.kindlist.Split(',');
                    var kindlist = new List<int>();
                    foreach (var k in kinds)
                    {
                        kindlist.Add(int.Parse(k));
                    }
                    var mudidiList = from b in db.sline_destinations
                                     from c in kindlist
                                     where b.id == c
                                     select b;
                    tripInfo.MudidiList = mudidiList.ToList();

                    var attrs = tripInfo.Info.attrid.Split(',');
                    var alist = new List<int>();
                    foreach (var a in attrs)
                    {
                        alist.Add(int.Parse(a));
                    }
                    var attrList = from b in db.sline_line_attr
                                   from c in alist
                                   where b.id == c
                                   select b;
                    tripInfo.AttrList = attrList.ToList();
                }

                return tripInfo;
            }
        }

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

            if (!string.IsNullOrEmpty(pageParam.title))
            {
                trips = trips.Where(p => p.title.Contains(pageParam.title));
            }

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
                trips = trips.Where(p => ("," + p.kindlist + ",").Contains(("," + pageParam.kindlist + ",")));
            }

            if (!string.IsNullOrEmpty(pageParam.attrid))
            {
                trips = trips.Where(p => ("," + p.attrid + ",").Contains(("," + pageParam.attrid + ",")));
            }

            pageParam.total = trips.Count();
            if (!string.IsNullOrEmpty(pageParam.orderprice))
            {
                if (pageParam.isDesc)
                    trips = trips.OrderByDescending(c => c.storeprice).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    trips = trips.OrderBy(c => c.storeprice).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            else
            {
                if (pageParam.isDesc)
                    trips = trips.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    trips = trips.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            return trips;
        }
    }
}
