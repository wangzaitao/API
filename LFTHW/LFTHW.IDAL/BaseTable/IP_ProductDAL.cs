using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_ProductDAL: IBaseDAL<P_Product>
    {
        bool Delete(int id);

        P_Product GetById(int id);

        bool Update(P_Product pProduct);

        bool Edit(ProductBasicInfo product);
    }
}
