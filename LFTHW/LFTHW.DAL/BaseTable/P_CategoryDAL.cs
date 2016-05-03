using System.Linq;
using System.Collections.Generic;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_CategoryDAL : BaseDAL<P_Category>, IP_CategoryDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pCategory = db.P_Category.FirstOrDefault(s => s.ID == id);
                db.P_Category.Remove(pCategory);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Category GetById(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pCategory = db.P_Category.FirstOrDefault(s => s.ID == id);
                return pCategory;
            }
        }

        public bool Update(P_Category pCategory)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pCategory = db.P_Category.FirstOrDefault(s => s.ID == pCategory.ID);
                _pCategory.ID = pCategory.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public IQueryable<P_Category> GetByTypeID(long typeid)
        {
            var db = new LFTHWDBModel();
            var pCategory = from a in db.P_Category
                            join b in db.P_TypeCategory on a.ID equals b.CategoryID
                            where b.TypeID == typeid
                            select a;
            return pCategory;
        }

        public IQueryable<P_Category> GetByPId(long pid)
        {
            var db = new LFTHWDBModel();
            var pCategory = from c in db.P_Category
                            where c.PID == pid
                            select c;

            return pCategory;
        }

        public IEnumerable<P_Category> GetTree(long pid)
        {
            var db = new LFTHWDBModel();
            var pCategory = db.P_Category.SqlQuery("WITH Tree AS(SELECT P.* FROM dbo.P_Category P WHERE P.PID = " + pid + " UNION ALL SELECT C.* FROM dbo.P_Category C INNER JOIN Tree T ON C.PID = T.ID) SELECT * FROM Tree").OrderBy(c => c.PID);

            return pCategory;
        }
    }
}
