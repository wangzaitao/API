using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_CityBLL : IBaseBLL<S_City>
    {
        bool Delete(int id);
        S_City GetById(int id);
        bool Update(S_City sCity);
    }
}
