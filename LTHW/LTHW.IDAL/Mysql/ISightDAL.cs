using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface ISightDAL : IBaseDAL<sline_spot>
    {
        IQueryable<SightListEntity> GetPage(SightQueryParam pageParam);

        SightInfoEntity getById(int id);

        List<sline_spot_attr> GetSpotAttrTree(long pid);
    }
}
