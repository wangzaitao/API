using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_OrderBLL : IBaseBLL<UP_Order>
    {
        bool Delete(int id);
        UP_Order GetById(int id);
        bool Update(UP_Order upOrder);
    }
}
