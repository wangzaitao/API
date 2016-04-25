using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_PictureDAL: IBaseDAL<P_Picture>
    {
        bool Delete(int id);

        P_Picture GetById(int id);

        bool Update(P_Picture pPicture);
    }
}
