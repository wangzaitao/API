using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_CategoryDAL: IBaseDAL<P_Category>
    {
        bool Delete(int id);

        P_Category GetById(int id);

        bool Update(P_Category pCategory);
    }
}
