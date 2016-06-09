using System;
using System.Linq;
using System.Linq.Expressions;

namespace LTHW.IDAL
{
    public interface IBaseDAL<T> where T : class
    {
        T Add(T entity);
        bool Update(T entity, string[] property);
        bool Delete(T entity);
        IQueryable<T> QueryAll();
        IQueryable<T> QueryByWhere(Expression<Func<T, bool>> whereLamda);
        #region
        ///// <summary>
        ///// 对查询结果进行升序排序
        ///// </summary>
        ///// <typeparam name="S">排序字段类型</typeparam>
        ///// <param name="queryable">查询结果</param>
        ///// <param name="orderLamda">排序表达式</param>
        ///// <returns>根据排序条件排序好之后的排序结果</returns>
        //IOrderedQueryable<T> Order<S>(IQueryable<T> queryable, Expression<Func<T, S>> orderLamda);
        ///// <summary>
        ///// 对排序结果再次进行升序排序
        ///// </summary>
        ///// <typeparam name="S">排序字段类型</typeparam>
        ///// <param name="queryable">根据排序条件排序好之后的排序结果</param>
        ///// <param name="orderLamda">排序表达式</param>
        ///// <returns>根据排序条件排序好之后的排序结果</returns>
        //IOrderedQueryable<T> ThenOrder<S>(IOrderedQueryable<T> queryable, Expression<Func<T, S>> orderLamda);
        ///// <summary>
        ///// 对查询结果进行降序排序
        ///// </summary>
        ///// <typeparam name="S">排序字段类型</typeparam>
        ///// <param name="queryable">查询结果</param>
        ///// <param name="orderLamda">排序表达式</param>
        ///// <returns>根据排序条件排序好之后的排序结果</returns>
        //IOrderedQueryable<T> OrderDesc<S>(IQueryable<T> queryable, Expression<Func<T, S>> orderLamda);
        ///// <summary>
        ///// 对排序结果再次进行降序排序
        ///// </summary>
        ///// <typeparam name="S">排序字段类型</typeparam>
        ///// <param name="queryable">根据排序条件排序好之后的排序结果</param>
        ///// <param name="orderLamda">排序表达式</param>
        ///// <returns>根据排序条件排序好之后的排序结果</returns>
        //IOrderedQueryable<T> ThenOrderDesc<S>(IOrderedQueryable<T> queryable, Expression<Func<T, S>> orderLamda);
        ///// <summary>
        ///// 对排序结果进行分页操作
        ///// </summary>
        ///// <param name="queryable">根据排序条件排序好之后的排序结果</param>
        ///// <param name="nowNum">跳过序列中指定数量的元素</param>
        ///// <param name="pageSize">从序列的开头返回指定数量的连续元素</param>
        ///// <returns>指定长度的列表</returns>
        //IQueryable<T> QueryPageEnties(IOrderedQueryable<T> queryable, int nowNum, int pageSize);
        #endregion
        IQueryable<T> QueryPages<S>(Expression<Func<T, bool>> whereLamda, Expression<Func<T, S>> orderLamda, bool isDesc, int pageIndex, int pageSize, out int rowCount);
    }
}
