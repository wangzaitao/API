using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_BrandBLL : IBaseBLL<P_Brand>
    {
        bool Delete(int id);
        P_Brand GetById(int id);
        bool Update(P_Brand pBrand);

        bool Edit(BrandCategory pBrandCategory);
    }
}
