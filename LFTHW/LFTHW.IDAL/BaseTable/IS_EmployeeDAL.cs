using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_EmployeeDAL: IBaseDAL<S_Employee>
    {
        bool Delete(int id);

        S_Employee GetById(int id);

        bool Update(S_Employee sEmployee);
    }
}
