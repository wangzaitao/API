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
    public class SightBLL : BaseBLL<sline_spot>, ISightBLL
    {
        private readonly ISightDAL _ISightDAL;
        public SightBLL()
            : base()
        {
            _ISightDAL = new SightDAL();
        }

        public List<SightListEntity> GetPage(SightQueryParam pageParam)
        {
            return _ISightDAL.GetPage(pageParam).ToList<SightListEntity>();
        }

        public SightInfoEntity GetById(int id)
        {
            return _ISightDAL.GetById(id);
        }

        public List<TreeObject> GetSpotAttrTree(long pid) {
            var desList = _ISightDAL.GetSpotAttrTree(pid);
            var treeList = new List<TreeObject>();
            foreach (var des in desList)
            {
                if (des.pid == pid)
                {
                    treeList.Add(new TreeObject
                    {
                        id = des.id,
                        text = des.attrname,
                        pid = des.pid,
                        nodes = new List<TreeObject>()
                    });
                }
                else
                {
                    treeList = CommonTreeBLL.GenerateTree(treeList, des.id, des.pid, des.attrname);
                }
            }

            return treeList;
        }
    }
}
