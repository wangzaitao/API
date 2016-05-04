using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_PdtInfoBLL : IBaseBLL<P_PdtInfo>
    {
        bool Delete(int id);
        P_PdtInfo GetByPdtID(long pdtID);
        bool Update(P_PdtInfo pPdtInfo);

        bool UpdateTripInfoRoute(TripInfoRoute tripInfoRoute, string[] property);
    }
}
