using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_PriceBLL : IBaseBLL<P_Price>
    {
        bool Delete(int id);
        P_Price GetById(int id);
        bool Update(P_Price pPrice);
    }
}
