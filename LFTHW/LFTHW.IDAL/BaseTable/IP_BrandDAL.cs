using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_BrandDAL: IBaseDAL<P_Brand>
    {
        bool Delete(int id);

        P_Brand GetById(int id);

        bool Update(P_Brand pBrand);
    }
}
