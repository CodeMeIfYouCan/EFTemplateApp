using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EFTemplateCore.Interfaces
{
    /// <summary>
    /// Default Repository interface.
    /// todo:Delete the unneccesary methods
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
         IQueryable<TEntity> AsQueryable();
         int Count();
         int Count(Expression<Func<TEntity, bool>> predicate);
         IQueryable<TEntity> Table();
         IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
         IQueryable<TEntity> Pagination(Expression<Func<TEntity, bool>> filter, out int total, int pageIndex = 0, int pageSize = 50, int minPage = 1, int maxPage = int.MaxValue);
         IQueryable<TEntity> Top(int size = 50);
         EntityEntry<TEntity> Add(TEntity entity);
         List<EntityEntry<TEntity>> Add(IList<TEntity> entityList);
         void Update(TEntity entity);
         void Update(IList<TEntity> entityList);
         void HardDelete(TEntity entity);
         void HardDelete(IList<TEntity> entityList);
         void HardDelete(Expression<Func<TEntity, bool>> predicate);
         void SoftDelete(TEntity entity);
         void SoftDelete(IList<TEntity> entityList);
         void SoftDelete(Expression<Func<TEntity, bool>> predicate);
         TEntity First(Expression<Func<TEntity, bool>> predicate);
         TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
         TEntity Single(Expression<Func<TEntity, bool>> predicate);
         TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
         bool Exist(Expression<Func<TEntity, bool>> predicate);
         IEnumerable<TEntity> GetCustomQuery(string query, SqlParameters parameters);
         IEnumerable<TEntity> CallSp(string spName, SqlParameters parameters);
    }
}


