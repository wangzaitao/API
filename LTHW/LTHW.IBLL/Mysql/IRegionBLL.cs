using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface IRegionBLL
    {
        List<sline_region_province> GetProvince();
        List<sline_region_city> GetCityByProvince(int provid);        
        List<sline_region_county> GetCountyByCity(int cityid);
    }
}
