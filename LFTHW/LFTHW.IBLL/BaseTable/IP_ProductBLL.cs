using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_ProductBLL : IBaseBLL<P_Product>
    {
        bool Delete(int id);
        P_Product GetById(int id);
        bool Update(P_Product pProduct);
    }
}
