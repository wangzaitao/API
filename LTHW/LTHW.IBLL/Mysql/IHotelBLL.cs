using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface IHotelBLL : IBaseBLL<sline_hotel>
    {
        List<HotelListEntity> GetPage(HotelQueryParam pageParam);

        HotelInfoEntity getById(int id);

        List<TreeObject> GetHotelAttrTree(long pid);
    }
}
