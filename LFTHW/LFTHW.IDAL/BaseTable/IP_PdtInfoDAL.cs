using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_PdtInfoDAL: IBaseDAL<P_PdtInfo>
    {
        bool Delete(int id);

        P_PdtInfo GetById(int id);

        bool Update(P_PdtInfo pPdtInfo);

        bool UpdateTripInfoRoute(TripInfoRoute tripInfoRoute, string[] property);
    }
}
