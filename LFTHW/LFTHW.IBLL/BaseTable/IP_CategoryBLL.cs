using System.Collections.Generic;
using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_CategoryBLL : IBaseBLL<P_Category>
    {
        bool Delete(int id);
        P_Category GetById(int id);
        bool Update(P_Category pCategory);
        List<P_Category> GetByTypeID(long typeid);
        bool Edit(CategoryType categoryType);
        List<P_Category> GetByPId(long pid);
        List<P_Category> GetTree(long pid);
    }
}
