using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_AdminDAL: IBaseDAL<S_Admin>
    {
        bool Delete(int id);

        S_Admin GetById(int id);

        bool Update(S_Admin sAdmin);
    }
}
