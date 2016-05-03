using System;
using System.Linq;
using LFTHW.IDAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace LFTHW.DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class
    {
        private DbContext db = DbContextFactory.GetCurrentDbContext();

        public T Add(T entity)
        {
            try
            {
                db.Entry<T>(entity).State = EntityState.Added;
                db.SaveChanges();
                return entity;
            }
            catch (Exception ex) {
                var tt = ex.Message;
                return null;
            }
        }
        public bool Update(T entity, string[] property)
        {
            DbEntityEntry<T> entry = db.Entry<T>(entity);
            entry.State = EntityState.Unchanged;
            foreach (var item in property)
            {
                entry.Property(item).IsModified = true;
            }
            return db.SaveChanges() > 0;
        }
        public bool Delete(T entity)
        {
            DbEntityEntry<T> entry = db.Entry<T>(entity);
            entry.State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
        public IQueryable<T> QueryAll()
        {
            return db.Set<T>();
        }
        public IQueryable<T> QueryByWhere(Expression<Func<T, bool>> whereLamda)
        {
            return db.Set<T>().Where<T>(whereLamda);
        }
        public IQueryable<T> QueryPages<S>(Expression<Func<T, bool>> whereLamda, Expression<Func<T, S>> orderLamda, bool isDesc, int pageIndex, int pageSize, out int rowCount)
        {
            var temp = db.Set<T>().Where<T>(whereLamda);
            rowCount = temp.Count();
            if (isDesc)
                temp = temp.OrderByDescending<T, S>(orderLamda).Skip<T>(pageSize * (pageIndex - 1) + 1).Take<T>(pageSize);
            else
                temp = temp.OrderBy<T, S>(orderLamda).Skip<T>(pageSize * (pageIndex - 1) + 1).Take<T>(pageSize);
            return temp;
        }
    }
}
