using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class MuDiDiADL : BaseDAL<sline_destinations>, IMuDiDiDAL
    {
        public List<sline_destinations> GetTree(long pid) {
            var db = new LTHWMysqlModel();
            //var query = from c in db.sline_destinations
            //            where c.pid == pid
            //            select new TreeObject { id=c.id,text=c.kindname, nodes= GetTree(c.id) };

            //return query.ToList();

            var query = from c in db.sline_destinations
                        where c.pid == pid
                        select c;

            return query.ToList().Concat(query.ToList().SelectMany(t => GetTree(t.id))).ToList();
        }
    }
}
