using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_CartDAL: IBaseDAL<UP_Cart>
    {
        bool Delete(int id);

        UP_Cart GetById(int id);

        bool Update(UP_Cart upCart);
    }
}
