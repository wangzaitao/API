using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using LTHW.IBLL;
using LTHW.IDAL;
using LTHW.DAL;

namespace LTHW.BLL
{
    public class BaseBLL<T> : IBaseBLL<T> where T : class
    {
        private readonly IBaseDAL<T> _IBaseDAL;
        public BaseBLL()
        {
            _IBaseDAL = new BaseDAL<T>();
        }

        public T Add(T entity)
        {
            return _IBaseDAL.Add(entity);
        }

        public bool Update(T entity, string[] property)
        {
            return _IBaseDAL.Update(entity, property);
        }

        public bool Delete(T entity)
        {
            return _IBaseDAL.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _IBaseDAL.QueryAll().ToList<T>();
        }

        public List<T> GetByWhere(Expression<Func<T, bool>> whereLamda)
        {
            return _IBaseDAL.QueryByWhere(whereLamda).ToList<T>();
        }

        public List<T> GetPages<S>(Expression<Func<T, bool>> whereLamda, Expression<Func<T, S>> orderLamda, bool isDesc, int pageIndex, int pageSize, out int rowCount)
        {
            return _IBaseDAL.QueryPages(whereLamda, orderLamda, isDesc, pageIndex, pageSize, out rowCount).ToList<T>();
        }
    }
}
