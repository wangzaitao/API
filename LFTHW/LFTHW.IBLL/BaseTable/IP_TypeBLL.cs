using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_TypeBLL : IBaseBLL<P_Type>
    {
        bool Delete(int id);
        P_Type GetById(int id);
        bool Update(P_Type pType);
    }
}
