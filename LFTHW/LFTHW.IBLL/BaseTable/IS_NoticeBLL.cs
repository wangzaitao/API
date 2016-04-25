using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_NoticeBLL : IBaseBLL<S_Notice>
    {
        bool Delete(int id);
        S_Notice GetById(int id);
        bool Update(S_Notice sNotice);
    }
}
