using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_CategoryBLL : IBaseBLL<P_Category>
    {
        bool Delete(int id);
        P_Category GetById(int id);
        bool Update(P_Category pCategory);
    }
}
