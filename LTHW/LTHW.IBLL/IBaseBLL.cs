using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LTHW.IBLL
{
    public interface IBaseBLL<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity, string[] property);
        bool Delete(T entity);
        List<T> GetAll();
        List<T> GetByWhere(Expression<Func<T, bool>> whereLamda);
        List<T> GetPages<S>(Expression<Func<T, bool>> whereLamda, Expression<Func<T, S>> orderLamda, bool isDesc, int pageIndex, int pageSize, out int rowCount);
    }
}
