using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_NoticeDAL: IBaseDAL<S_Notice>
    {
        bool Delete(int id);

        S_Notice GetById(int id);

        bool Update(S_Notice sNotice);
    }
}
