using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_EmployeeDAL : BaseDAL<S_Employee>, IS_EmployeeDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sEmployee = db.S_Employee.FirstOrDefault(s => s.ID == id);  
                db.S_Employee.Remove(sEmployee); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_Employee GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sEmployee = db.S_Employee.FirstOrDefault(s => s.ID == id);
                return sEmployee;
            }
        }

        public bool Update(S_Employee sEmployee) {
            using (var db = new LFTHWDBModel())
            {
                var _sEmployee = db.S_Employee.FirstOrDefault(s => s.ID == sEmployee.ID);
                _sEmployee.ID = sEmployee.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
