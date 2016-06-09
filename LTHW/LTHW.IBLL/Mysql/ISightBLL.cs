using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface ISightBLL : IBaseBLL<sline_spot>
    {
        List<SightListEntity> GetPage(SightQueryParam pageParam);

        SightInfoEntity getById(int id);

        List<TreeObject> GetSpotAttrTree(long pid);
    }
}
