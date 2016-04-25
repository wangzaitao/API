using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_TypeDAL : IBaseDAL<P_Type>
    {
        bool Delete(int id);
        P_Type GetById(int id);

        bool Update(P_Type pType);
    }
}
