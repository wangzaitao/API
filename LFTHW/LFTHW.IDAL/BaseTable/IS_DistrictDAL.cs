using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_DistrictDAL: IBaseDAL<S_District>
    {
        bool Delete(int id);

        S_District GetById(int id);

        bool Update(S_District sDistrict);
    }
}
