using System.Linq;
using System.Collections.Generic;
using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_CategoryBLL : BaseBLL<P_Category>, IP_CategoryBLL
    {
        private readonly IP_CategoryDAL _IP_CategoryDAL;
        public P_CategoryBLL()
            : base()
        {
            _IP_CategoryDAL = new P_CategoryDAL();
        }

        public bool Delete(int id)
        {
            return _IP_CategoryDAL.Delete(id);
        }

        public P_Category GetById(int id)
        {
            return _IP_CategoryDAL.GetById(id);
        }
        public bool Update(P_Category pCategory)
        {
            return _IP_CategoryDAL.Update(pCategory);
        }

        public bool Edit(CategoryType categoryType) {
            return _IP_CategoryDAL.Edit(categoryType);
        }

        public List<P_Category> GetByTypeID(long typeid)
        {
            return _IP_CategoryDAL.GetByTypeID(typeid).ToList<P_Category>();
        }

        public List<P_Category> GetByPId(long pid)
        {
            return _IP_CategoryDAL.GetByPId(pid).ToList<P_Category>();
        }

        public List<P_Category> GetTree(long pid)
        {
            return _IP_CategoryDAL.GetTree(pid).ToList<P_Category>();
        }

        public List<CategoryType> GetPage(TypeQueryParam pageParam) {
            return _IP_CategoryDAL.GetPage(pageParam).ToList<CategoryType>();
        }
    }
}

