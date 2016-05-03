using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_RouteDAL: IBaseDAL<P_Route>
    {
        bool Delete(int id);

        P_Route GetById(int id);

        bool Update(P_Route pRoute);
    }
}
