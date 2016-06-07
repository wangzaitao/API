using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LTHW.Utility
{
    public class LinqHelper
    {
        public static Func<T, Tkey> DynamicLambda<T, Tkey>(string propertyName)
        {
            ParameterExpression p = Expression.Parameter(typeof(T), "p");
            Expression body = Expression.Property(p, typeof(T).GetProperty(propertyName));

            var lambda = Expression.Lambda<Func<T, Tkey>>(body, p);

            return lambda.Compile();
        }
    }
}
