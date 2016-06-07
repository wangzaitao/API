using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LTHW.Utility
{
    public static class LinqOrderExtensions
    {
        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string propertyStr) where TEntity : class
        {
            ParameterExpression param = Expression.Parameter(typeof(TEntity), "c");
            PropertyInfo property = typeof(TEntity).GetProperty(propertyStr);
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression le = Expression.Lambda(propertyAccessExpression, param);
            Type type = typeof(TEntity);
            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), "OrderBy", new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(le));
            return source.Provider.CreateQuery<TEntity>(resultExp);
        }
    }
}
