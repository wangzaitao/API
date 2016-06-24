using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class RegionDAL : IRegionDAL
    {

        public IQueryable<sline_region_province> GetProvince()
        {
            var db = new LTHWMysqlModel();
            var provinces = from p in db.sline_region_province select p;
            return provinces;
        }
        public IQueryable<sline_region_city> GetCityByProvince(int provid)
        {
            var db = new LTHWMysqlModel();
            var citys = from c in db.sline_region_city where c.provid == provid select c;
            return citys;
        }

        public IQueryable<sline_region_county> GetCountyByCity(int cityid)
        {
            var db = new LTHWMysqlModel();
            var countys = from c in db.sline_region_county where c.cityid == cityid select c;
            return countys;
        }
    }
}
