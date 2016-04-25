using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_FXCommisionDAL: IBaseDAL<S_FXCommision>
    {
        bool Delete(int id);

        S_FXCommision GetById(int id);

        bool Update(S_FXCommision sFXCommision);
    }
}
