using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_ParamBLL : IBaseBLL<P_Param>
    {
        bool Delete(int id);
        P_Param GetById(int id);
        bool Update(P_Param pParam);
    }
}
