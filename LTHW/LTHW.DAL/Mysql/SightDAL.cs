using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class SightDAL : BaseDAL<sline_spot>, ISightDAL
    {
        public SightInfoEntity getById(int id)
        {
            using (var db = new LTHWMysqlModel())
            {
                var sights = from b in db.sline_spot_ticket
                             join a in db.sline_spot on b.spotid equals a.id
                             join c in db.sline_spot_ticket_type on b.tickettypeid equals c.id into temp
                             from tt in temp.DefaultIfEmpty()
                             where b.id == id
                             select new SightInfoEntity
                             {
                                 id = b.id,
                                 spotid = b.spotid,
                                 sellprice = b.sellprice,
                                 ourprice = b.ourprice,
                                 kindname = tt == null ? "" : tt.kindname,
                                 address = a.address,
                                 aid = a.aid,
                                 booknotice = a.booknotice,
                                 content = a.content,
                                 friendtip = a.friendtip,
                                 getway = a.getway,
                                 modtime = a.modtime,
                                 piclist = a.piclist,
                                 price = a.price,
                                 sellpoint = a.sellpoint,
                                 shortname = a.shortname,
                                 title = a.title,
                                 webid = a.webid,
                                 attrid = a.attrid,
                                 bookcount = a.bookcount,
                                 recommendnum = a.recommendnum,
                                 satisfyscore = a.satisfyscore,
                                 isding = a.isding,
                                 isjian = a.isjian,
                                 lat = a.lat,
                                 lng = a.lng,
                                 litpic = a.litpic,
                                 kindlist = a.kindlist
                             };
                return sights.FirstOrDefault();
            }
        }

        public IQueryable<SightListEntity> GetPage(SightQueryParam pageParam)
        {
            var db = new LTHWMysqlModel();
            var sights = from b in db.sline_spot_ticket
                         join a in db.sline_spot on b.spotid equals a.id
                         select new SightListEntity
                         {
                             id = b.id,
                             spotid = b.spotid,
                             sellprice = b.sellprice,
                             ourprice = b.ourprice,
                             address = a.address,
                             friendtip = a.friendtip,
                             getway = a.getway,
                             modtime = a.modtime,
                             piclist = a.piclist,
                             sellpoint = a.sellpoint,
                             shortname = a.shortname,
                             title = a.title,
                             attrid = a.attrid,
                             bookcount = a.bookcount,
                             recommendnum = a.recommendnum,
                             satisfyscore = a.satisfyscore,
                             isding = a.isding,
                             isjian = a.isjian,
                             lat = a.lat,
                             lng = a.lng,
                             litpic = a.litpic,
                             kindlist = a.kindlist
                         };

            if (!string.IsNullOrEmpty(pageParam.title))
            {
                sights = sights.Where(p => p.title.Contains(pageParam.title));
            }

            if (pageParam.isjian >= 0)
            {
                sights = sights.Where(p => p.isjian == pageParam.isjian);
            }

            if (pageParam.isding >= 0)
            {
                sights = sights.Where(p => p.isding == pageParam.isding);
            }

            if (!string.IsNullOrEmpty(pageParam.kindlist))
            {
                sights = sights.Where(p => p.kindlist.Split(',').Contains(pageParam.kindlist));
            }

            if (!string.IsNullOrEmpty(pageParam.attrid))
            {
                sights = sights.Where(p => p.attrid.Split(',').Contains(pageParam.attrid));
            }

            pageParam.total = sights.Count();
            if (!string.IsNullOrEmpty(pageParam.orderprice))
            {
                if (pageParam.isDesc)
                    sights = sights.OrderByDescending(c => c.ourprice).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    sights = sights.OrderBy(c => c.ourprice).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            else
            {
                if (pageParam.isDesc)
                    sights = sights.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    sights = sights.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            return sights;
        }

        public List<sline_spot_attr> GetSpotAttrTree(long pid)
        {
            var db = new LTHWMysqlModel();

            var query = from c in db.sline_spot_attr
                        where c.pid == pid && c.isopen == 1
                        select c;

            return query.ToList().Concat(query.ToList().SelectMany(t => GetSpotAttrTree(t.id))).ToList();
        }
    }
}
