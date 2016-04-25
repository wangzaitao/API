using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IP_ParamDAL: IBaseDAL<P_Param>
    {
        bool Delete(int id);

        P_Param GetById(int id);

        bool Update(P_Param pParam);
    }
}
