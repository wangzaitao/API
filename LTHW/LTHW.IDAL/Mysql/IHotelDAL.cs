using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface IHotelDAL : IBaseDAL<sline_hotel>
    {
        IQueryable<HotelListEntity> GetPage(HotelQueryParam pageParam);

        HotelInfoEntity GetById(int id);

        List<sline_hotel_attr> GetHotelAttrTree(long pid);
    }
}
