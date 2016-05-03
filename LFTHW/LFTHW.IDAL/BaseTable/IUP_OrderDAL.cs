using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_OrderDAL: IBaseDAL<UP_Order>
    {
        bool Delete(int id);

        UP_Order GetById(int id);

        bool Update(UP_Order upOrder);
    }
}
