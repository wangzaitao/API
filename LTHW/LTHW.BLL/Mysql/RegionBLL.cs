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
    public class RegionBLL : IRegionBLL
    {
        private readonly IRegionDAL _IRegionDAL;
        public RegionBLL()
            : base()
        {
            _IRegionDAL = new RegionDAL();
        }

        public List<sline_region_province> GetProvince() {
            return _IRegionDAL.GetProvince().ToList<sline_region_province>();
        }

        public List<sline_region_city> GetCityByProvince(int provid) {
            return _IRegionDAL.GetCityByProvince(provid).ToList<sline_region_city>();
        }
        public List<sline_region_county> GetCountyByCity(int cityid) {
            return _IRegionDAL.GetCountyByCity(cityid).ToList<sline_region_county>();
        }
    }
}
