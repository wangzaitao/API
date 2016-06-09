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
    public class MuDiDiBLL : BaseBLL<sline_destinations>, IMuDiDiBLL
    {
        private readonly IMuDiDiDAL _IMuDiDiDAL;
        public MuDiDiBLL()
            : base()
        {
            _IMuDiDiDAL = new MuDiDiADL();
        }

        public List<TreeObject> GetTree(long pid)
        {
            var desList = _IMuDiDiDAL.GetTree(pid);
            var treeList = new List<TreeObject>();
            foreach (var des in desList)
            {
                if (des.pid == pid)
                {
                    treeList.Add(new TreeObject
                    {
                        id = des.id,
                        text = des.kindname,
                        pid = des.pid,
                        nodes = new List<TreeObject>()
                    });
                }
                else
                {
                    treeList = CommonTreeBLL.GenerateTree(treeList, des.id, des.pid, des.kindname);
                }
            }

            return treeList;
        }


    }
}
