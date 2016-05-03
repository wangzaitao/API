using System.Collections.Generic;
using System.Linq;
using LFTHW.Model;

namespace LFTHW.IDAL
{
    public interface IP_CategoryDAL: IBaseDAL<P_Category>
    {
        bool Delete(int id);

        P_Category GetById(int id);

        bool Update(P_Category pCategory);

        bool Edit(CategoryType categoryType);

        IQueryable<P_Category> GetByTypeID(long typeid);

        IQueryable<P_Category> GetByPId(long pid);

        IEnumerable<P_Category> GetTree(long pid);
    }
}
