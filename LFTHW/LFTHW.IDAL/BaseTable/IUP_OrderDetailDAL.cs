using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_OrderDetailDAL: IBaseDAL<UP_OrderDetail>
    {
        bool Delete(int id);

        UP_OrderDetail GetById(int id);

        bool Update(UP_OrderDetail upOrderDetail);
    }
}
