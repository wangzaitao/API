using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_CartBLL : IBaseBLL<UP_Cart>
    {
        bool Delete(int id);
        UP_Cart GetById(int id);
        bool Update(UP_Cart upCart);
    }
}
