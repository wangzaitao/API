using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_FXCommisionBLL : IBaseBLL<S_FXCommision>
    {
        bool Delete(int id);
        S_FXCommision GetById(int id);
        bool Update(S_FXCommision sFXCommision);
    }
}
