using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_OrderDetailBLL : IBaseBLL<UP_OrderDetail>
    {
        bool Delete(int id);
        UP_OrderDetail GetById(int id);
        bool Update(UP_OrderDetail upOrderDetail);
    }
}
