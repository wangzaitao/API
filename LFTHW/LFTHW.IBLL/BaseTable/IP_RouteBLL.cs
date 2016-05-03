using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_RouteBLL : IBaseBLL<P_Route>
    {
        bool Delete(int id);
        P_Route GetById(int id);
        bool Update(P_Route pRoute);
    }
}
