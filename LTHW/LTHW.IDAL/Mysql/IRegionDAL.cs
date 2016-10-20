using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface IRegionDAL
    {
        IQueryable<sline_region_province> GetProvince();
        IQueryable<sline_region_city> GetCityByProvince(int provid);
        IQueryable<sline_region_county> GetCountyByCity(int cityid);
    }
}
