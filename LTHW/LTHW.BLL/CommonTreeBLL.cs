using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.BLL
{
    public class CommonTreeBLL
    {
        public static List<TreeObject> GenerateTree(List<TreeObject> treeList, long id,int? pid,string title)
        {
            if (treeList != null && treeList.Count > 0)
            {
                foreach (var tree in treeList)
                {
                    if (pid == tree.id)
                    {
                        if (tree.nodes == null)
                        {
                            tree.nodes = new List<TreeObject>();
                        }
                        tree.nodes.Add(new TreeObject { id = id, text = title, pid = pid });
                    }
                    else
                    {
                        GenerateTree(tree.nodes, id, pid, title);
                    }
                }
            }
            return treeList;
        }
    }
}
