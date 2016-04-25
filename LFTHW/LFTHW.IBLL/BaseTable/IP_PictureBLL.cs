using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_PictureBLL : IBaseBLL<P_Picture>
    {
        bool Delete(int id);
        P_Picture GetById(int id);
        bool Update(P_Picture pPicture);
    }
}
