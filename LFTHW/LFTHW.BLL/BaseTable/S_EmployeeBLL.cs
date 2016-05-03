using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_EmployeeBLL : BaseBLL<S_Employee>, IS_EmployeeBLL
    {
        private readonly IS_EmployeeDAL _IS_EmployeeDAL;
        public S_EmployeeBLL()
            : base()
        {
            _IS_EmployeeDAL = new S_EmployeeDAL();
        }

        public bool Delete(int id) {
            return _IS_EmployeeDAL.Delete(id);
        }

        public S_Employee GetById(int id)
        {
            return _IS_EmployeeDAL.GetById(id);
        }
        public bool Update(S_Employee sEmployee)
        {
            return _IS_EmployeeDAL.Update(sEmployee);
        }
    }
}

