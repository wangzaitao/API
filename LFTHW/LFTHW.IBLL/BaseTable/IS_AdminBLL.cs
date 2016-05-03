using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_AdminBLL : IBaseBLL<S_Admin>
    {
        bool Delete(int id);
        S_Admin GetById(int id);
        bool Update(S_Admin sAdmin);
    }
}
