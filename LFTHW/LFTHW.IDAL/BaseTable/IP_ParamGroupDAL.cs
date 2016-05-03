using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_ParamGroupDAL: IBaseDAL<P_ParamGroup>
    {
        bool Delete(int id);

        P_ParamGroup GetById(int id);

        bool Update(P_ParamGroup pParamGroup);
    }
}
