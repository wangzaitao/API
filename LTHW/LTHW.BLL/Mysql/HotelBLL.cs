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
    public class HotelBLL : BaseBLL<sline_hotel>, IHotelBLL
    {
        private readonly IHotelDAL _IHotelDAL;
        public HotelBLL()
            : base()
        {
            _IHotelDAL = new HotelDAL();
        }

        public List<HotelListEntity> GetPage(HotelQueryParam pageParam)
        {
            return _IHotelDAL.GetPage(pageParam).ToList<HotelListEntity>();
        }

        public HotelInfoEntity getById(int id)
        {
            return _IHotelDAL.getById(id);
        }

        public List<TreeObject> GetHotelAttrTree(long pid) {
            var desList = _IHotelDAL.GetHotelAttrTree(pid);
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
