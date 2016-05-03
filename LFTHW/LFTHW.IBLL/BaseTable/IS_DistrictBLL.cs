using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_DistrictBLL : IBaseBLL<S_District>
    {
        bool Delete(int id);
        S_District GetById(int id);
        bool Update(S_District sDistrict);
    }
}
