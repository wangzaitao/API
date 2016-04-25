using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_UserConsumeBLL : IBaseBLL<UP_UserConsume>
    {
        bool Delete(int id);
        UP_UserConsume GetById(int id);
        bool Update(UP_UserConsume upUserConsume);
    }
}
