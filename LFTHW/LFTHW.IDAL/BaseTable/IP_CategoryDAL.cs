using LFTHW.Model;
using System.Linq;

namespace LFTHW.IDAL
{
    public interface IP_CategoryDAL: IBaseDAL<P_Category>
    {
        bool Delete(int id);

        P_Category GetById(int id);

        bool Update(P_Category pCategory);

        IQueryable<P_Category> GetByTypeID(int typeid);
    }
}
