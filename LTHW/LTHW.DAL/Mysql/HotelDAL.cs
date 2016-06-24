using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class HotelDAL : BaseDAL<sline_hotel>, IHotelDAL
    {
        public HotelInfoEntity GetById(int id)
        {
            using (var db = new LTHWMysqlModel())
            {
                var hotels = from a in db.sline_hotel
                             where a.id == id
                             select new HotelInfoEntity
                             {
                                 address = a.address,
                                 aid = a.aid,
                                 content = a.content,
                                 modtime = a.modtime,
                                 piclist = a.piclist,
                                 price = a.price,
                                 sellpoint = a.sellpoint,
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
                                 kindlist = a.kindlist,
                                 litpic = a.litpic,
                                 aroundspots = a.aroundspots,
                                 decoratetime = a.decoratetime,
                                 description = a.description,
                                 equipment = a.equipment,
                                 fuwu = a.fuwu,
                                 hotelrankid = a.hotelrankid,
                                 id = a.id,
                                 mainrankid = a.mainrankid,
                                 notice = a.notice,
                                 opentime = a.opentime,
                                 telephone = a.telephone,
                                 traffic = a.traffic
                             };
                var hotel = hotels.FirstOrDefault();

                if (hotel != null)
                {
                    var roomList = from b in db.sline_hotel_room
                                   where b.hotelid == id
                                   select b;
                    hotel.RoomList = roomList.ToList();

                    var kinds = hotel.kindlist.Split(',');
                    var kindlist = new List<int>();
                    foreach (var k in kinds)
                    {
                        kindlist.Add(int.Parse(k));
                    }
                    var mudidiList = from b in db.sline_destinations
                                     from c in kindlist
                                     where b.id == c
                                     select b;
                    hotel.MudidiList = mudidiList.ToList();

                    var attrs = hotel.attrid.Split(',');
                    var alist = new List<int>();
                    foreach (var a in attrs)
                    {
                        alist.Add(int.Parse(a));
                    }
                    var attrList = from b in db.sline_hotel_attr
                                   from c in alist
                                   where b.id == c
                                   select b;
                    hotel.AttrList = attrList.ToList();
                }

                return hotel;
            }
        }

        public IQueryable<HotelListEntity> GetPage(HotelQueryParam pageParam)
        {
            var db = new LTHWMysqlModel();
            var hotels = from a in db.sline_hotel
                         select new HotelListEntity
                         {
                             address = a.address,
                             modtime = a.modtime,
                             piclist = a.piclist,
                             price = a.price,
                             sellpoint = a.sellpoint,
                             title = a.title,
                             attrid = a.attrid,
                             bookcount = a.bookcount,
                             recommendnum = a.recommendnum,
                             satisfyscore = a.satisfyscore,
                             isding = a.isding,
                             isjian = a.isjian,
                             lat = a.lat,
                             lng = a.lng,
                             kindlist = a.kindlist,
                             litpic = a.litpic,
                             decoratetime = a.decoratetime,
                             hotelrankid = a.hotelrankid,
                             id = a.id,
                             opentime = a.opentime,
                             telephone = a.telephone
                         };

            if (!string.IsNullOrEmpty(pageParam.title))
            {
                hotels = hotels.Where(p => p.title.Contains(pageParam.title));
            }

            if (pageParam.isjian >= 0)
            {
                hotels = hotels.Where(p => p.isjian == pageParam.isjian);
            }

            if (!string.IsNullOrEmpty(pageParam.isding))
            {
                hotels = hotels.Where(p => p.isding == pageParam.isding);
            }

            if (!string.IsNullOrEmpty(pageParam.kindlist))
            {
                hotels = hotels.Where(p => ("," + p.kindlist + ",").Contains(("," + pageParam.kindlist + ",")));
            }

            if (!string.IsNullOrEmpty(pageParam.attrid))
            {
                hotels = hotels.Where(p => ("," + p.attrid + ",").Contains(("," + pageParam.attrid + ",")));
            }


            pageParam.total = hotels.Count();
            if (!string.IsNullOrEmpty(pageParam.orderprice))
            {
                if (pageParam.isDesc)
                    hotels = hotels.OrderByDescending(c => c.price).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    hotels = hotels.OrderBy(c => c.price).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            else
            {
                if (pageParam.isDesc)
                    hotels = hotels.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    hotels = hotels.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            }
            return hotels;
        }

        public List<sline_hotel_attr> GetHotelAttrTree(long pid)
        {
            var db = new LTHWMysqlModel();

            var query = from c in db.sline_hotel_attr
                        where c.pid == pid && c.isopen == 1
                        select c;

            return query.ToList().Concat(query.ToList().SelectMany(t => GetHotelAttrTree(t.id))).ToList();
        }
    }
}
