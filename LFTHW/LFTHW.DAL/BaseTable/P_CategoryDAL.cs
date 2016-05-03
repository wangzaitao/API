using System.Linq;
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

        public IQueryable<P_Category> GetByTypeID(int typeid)
        {
            var db = new LFTHWDBModel();
            var pCategory = from a in db.P_Category
                            join b in db.P_TypeCategory on a.ID equals b.CategoryID
                            select a;
            return pCategory;
        }
    }
}
