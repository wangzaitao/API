using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_CityDAL: IBaseDAL<S_City>
    {
        bool Delete(int id);

        S_City GetById(int id);

        bool Update(S_City sCity);
    }
}
