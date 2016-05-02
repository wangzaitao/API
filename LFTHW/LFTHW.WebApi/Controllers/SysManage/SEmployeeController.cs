using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/semployee")]
    public class SEmployeeController : ApiController
    {
        readonly IS_EmployeeBLL _IS_EmployeeBLL;

        public SEmployeeController(IS_EmployeeBLL iS_EmployeeBLL)
        {
            _IS_EmployeeBLL = iS_EmployeeBLL;
        }

        [Route("getall")]
        public List<S_Employee> GetAll()
        {
            return _IS_EmployeeBLL.GetAll();
        }

        [Route("getbyid")]
        public S_Employee Get(int id)
        {
            return _IS_EmployeeBLL.GetById(id);
        }

        [Route("add")]
        public S_Employee PostAdd(S_Employee sEmployee)
        {
            return _IS_EmployeeBLL.Add(sEmployee);
        }

        [Route("update")]
        public bool PostEdit(S_Employee sEmployee)
        {
            return _IS_EmployeeBLL.Update(sEmployee, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IS_EmployeeBLL.Delete(id);
        }
    }
}


