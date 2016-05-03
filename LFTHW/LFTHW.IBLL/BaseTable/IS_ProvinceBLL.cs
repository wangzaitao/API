using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_ProvinceBLL : IBaseBLL<S_Province>
    {
        bool Delete(int id);
        S_Province GetById(int id);
        bool Update(S_Province sProvince);
    }
}
