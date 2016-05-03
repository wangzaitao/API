using System.Collections.Generic;
using System.Linq;
using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_TypeCategoryBLL : BaseBLL<P_TypeCategory>, IP_TypeCategoryBLL
    {
        private readonly IP_TypeCategoryDAL _IP_TypeCategoryDAL;
        private readonly IP_TypeDAL _IP_TypeDAL;
        private readonly IP_CategoryDAL _IP_CategoryDAL;
        public P_TypeCategoryBLL()
            : base()
        {
            _IP_TypeCategoryDAL = new P_TypeCategoryDAL();
            _IP_TypeDAL = new P_TypeDAL();
            _IP_CategoryDAL = new P_CategoryDAL();
        }

        public List<TreeObject> GetTree()
        {
            List<TreeObject> resList = new List<TreeObject>();
            var tList = _IP_TypeDAL.QueryAll().ToList<P_Type>();
            var ctreeList = _IP_CategoryDAL.GetTree(0).ToList();
            foreach (var t in tList)
            {
                TreeObject tree1 = new TreeObject();
                tree1.id = t.ID;
                tree1.text = t.Name;
                tree1.flag = "Type";
                tree1.nodes = new List<TreeObject>();
                var cList2 = _IP_CategoryDAL.GetByTypeID(t.ID).ToList<P_Category>();
                foreach (var c2 in cList2)
                {
                    TreeObject tree2 = new TreeObject();
                    tree2.id = c2.ID;
                    tree2.text = c2.Name;
                    tree1.flag = "Category";
                    tree2.nodes = new List<TreeObject>();

                    var cList3 = ctreeList.Where(cl2 => cl2.PID == c2.ID).ToList();
                    foreach (var c3 in cList3)
                    {
                        TreeObject tree3 = new TreeObject();
                        tree3.id = c3.ID;
                        tree3.text = c3.Name;
                        tree1.flag = "Category";
                        tree3.nodes = new List<TreeObject>();

                        var cList4 = ctreeList.Where(cl3 => cl3.PID == c3.ID).ToList();
                        foreach (var c4 in cList4)
                        {
                            TreeObject tree4 = new TreeObject();
                            tree4.id = c4.ID;
                            tree4.text = c4.Name;
                            tree1.flag = "Category";
                            tree4.nodes = new List<TreeObject>();

                            tree3.nodes.Add(tree4);
                        }

                        tree2.nodes.Add(tree3);
                    }

                    tree1.nodes.Add(tree2);
                }
                resList.Add(tree1);
            }

            //foreach (var t in tList)
            //{
            //    TreeObject tree1 = new TreeObject();
            //    tree1.text = t.Name;
            //    tree1.nodes = new List<TreeObject>();
            //    var cList2=_IP_CategoryDAL.GetByTypeID(t.ID).ToList<P_Category>();
            //    foreach(var c2 in cList2) {
            //        TreeObject tree2 = new TreeObject();
            //        tree2.text = c2.Name;
            //        tree2.nodes = new List<TreeObject>();

            //        var cList3 = _IP_CategoryDAL.GetByPId(c2.ID).ToList<P_Category>();
            //        foreach (var c3 in cList3)
            //        {
            //            TreeObject tree3 = new TreeObject();
            //            tree3.text = c3.Name;
            //            tree3.nodes = new List<TreeObject>();

            //            var cList4 = _IP_CategoryDAL.GetByPId(c3.ID).ToList<P_Category>();
            //            foreach (var c4 in cList4)
            //            {
            //                TreeObject tree4 = new TreeObject();
            //                tree4.text = c4.Name;
            //                tree4.nodes = new List<TreeObject>();

            //                tree3.nodes.Add(tree4);
            //            }

            //            tree2.nodes.Add(tree3);
            //        }

            //        tree1.nodes.Add(tree2);
            //    }

            //    resList.Add(tree1);
            //}

            return resList;
        }
    }
}

