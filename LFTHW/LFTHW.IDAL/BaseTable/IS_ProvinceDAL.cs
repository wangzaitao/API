using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_ProvinceDAL: IBaseDAL<S_Province>
    {
        bool Delete(int id);

        S_Province GetById(int id);

        bool Update(S_Province sProvince);
    }
}
