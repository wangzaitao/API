using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IP_ParamGroupBLL : IBaseBLL<P_ParamGroup>
    {
        bool Delete(int id);
        P_ParamGroup GetById(int id);
        bool Update(P_ParamGroup pParamGroup);
    }
}
