using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IS_EmployeeBLL : IBaseBLL<S_Employee>
    {
        bool Delete(int id);
        S_Employee GetById(int id);
        bool Update(S_Employee sEmployee);
    }
}
