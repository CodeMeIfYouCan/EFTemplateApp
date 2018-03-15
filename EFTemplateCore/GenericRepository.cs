using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EFTemplateCore.Interfaces;
using EFTemplateCore.Extensions;

namespace EFTemplateCore
{ 
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        internal EFContext context;
        internal DbSet<TEntity> dbSet;
        string safeCode;

        //public DbSet<TEntity> Table
        //{
        //    get { return dbSet; }
        //}

        public GenericRepository(EFContext context, string safeCode)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
            this.safeCode = safeCode;
            //SafeUtilities.SetConnectionString(this.context);
        }
        public GenericRepository(EFContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
            //SafeUtilities.SetConnectionString(context);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return dbSet.AsQueryable<TEntity>();
        }
        public int Count()
        {
            return dbSet.Count();
        }
        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Count(predicate);
        }
        public IQueryable<TEntity> All()
        {
            return dbSet.AsQueryable<TEntity>();
        }
        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).AsQueryable();
        }
        public IQueryable<TEntity> Pagination(Expression<Func<TEntity, bool>> filter, out int total, int pageIndex = 0, int pageSize = 50, int minPage = 1, int maxPage = 1000000000)
        {
            IQueryable<TEntity> query = dbSet.Where(filter).AsQueryable();
            total = query.Count();
            return query.Pagination(pageIndex, pageSize, minPage, maxPage);
        }
        public IQueryable<TEntity> Top(int size = 50)
        {
            return dbSet.Take(size).AsQueryable();
        }
        public EntityEntry<TEntity> Add(TEntity entity)
        {
            var newEntry = dbSet.Add(entity);
            context.SaveChanges();
            return newEntry;
        }
        public List<EntityEntry<TEntity>> Add(IList<TEntity> entityList)
        {
            List<EntityEntry<TEntity>> newEntityList = new List<EntityEntry<TEntity>>();
            foreach (var entity in entityList)
            {
                newEntityList.Add(dbSet.Add(entity));
            }
            context.SaveChanges();
            return newEntityList;
        }
        public void Update(TEntity entity)
        {
            var entry = context.Entry(entity);
            dbSet.Attach(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Update(IList<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                var entry = context.Entry(entity);
                dbSet.Attach(entity);
                entry.State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void HardDelete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            context.SaveChanges();
        }
        public void HardDelete(IList<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                if (context.Entry(entity).State == EntityState.Detached)
                {
                    dbSet.Attach(entity);
                }
                dbSet.Remove(entity);
            }
            context.SaveChanges();
        }
        public void HardDelete(Expression<Func<TEntity, bool>> predicate)
        {
            var entitiesToDelete = Filter(predicate);
            HardDelete(entitiesToDelete.ToList());
        }
        public void SoftDelete(TEntity entity)
        {
            PropertyInfo recordStatus = entity.GetType().GetProperty("RecordStatus", BindingFlags.Public | BindingFlags.Instance);
            if (recordStatus != null)
            {
                recordStatus.SetValue(entity, 'I', null);
                var entry = context.Entry(entity);
                dbSet.Attach(entity);
                entry.State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void SoftDelete(IList<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                PropertyInfo recordStatus = entity.GetType().GetProperty("RecordStatus", BindingFlags.Public | BindingFlags.Instance);
                if (recordStatus != null)
                {
                    recordStatus.SetValue(entity, 'I', null);
                    var entry = context.Entry(entity);
                    dbSet.Attach(entity);
                    entry.State = EntityState.Modified;
                }
            }
            context.SaveChanges();
        }
        public void SoftDelete(Expression<Func<TEntity, bool>> predicate)
        {

            var entitiesToDelete = Filter(predicate);
            SoftDelete(entitiesToDelete.ToList());

        }
        public TEntity First(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.First(predicate);
        }
        public TEntity FirstOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }
        public TEntity Single(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Single(predicate);
        }
        public TEntity SingleOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.SingleOrDefault(predicate);
        }
        public bool Exist(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Count(predicate) > 0;
        }
        public IEnumerable<TEntity> GetCustomQuery(string query, SqlParameters parameters)
        {
            return context.Database.GetCustomQuery<TEntity>(query, parameters);
        }
        public IEnumerable<TEntity> CallSp(string spName, SqlParameters parameters)
        {
            return context.Database.CallSp<TEntity>(spName, parameters);
        }
    }
}
