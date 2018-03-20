using System;
using System.Linq;
using System.Linq.Expressions;



namespace EFTemplateCore.Extensions
{
    /// <summary>
    /// Repository extension class. Paging,nolock usage etc.
    /// </summary>
    public static class RepositoryExtension
    {
        public static IQueryable<TEntity> Pagination<TEntity>(this IQueryable<TEntity> query, int pageIndex, int pageSize = 50, int minPage = 1, int maxPage = int.MaxValue)
        {
            if (pageIndex < minPage || pageIndex > maxPage)
            {
                throw new ArgumentOutOfRangeException(null, string.Format("Page index must >= {0} and =< {1}!", minPage, maxPage));
            }
            return query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
        }
        public static IQueryable<TEntity> Top<TEntity>(this IQueryable<TEntity> query, int size = 50)
        {
            return query.Take(size);
        }
        public static IQueryable<TEntity> Filter<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> predicate)
        {
            return query.Where(predicate).AsQueryable();
        }

        public static IQueryable<T> NoLock<T>(this IQueryable<T> query)
        {
            using (var txn = GetNewReadUncommittedScope())
            {
                return query.AsQueryable();
            }
        }

        public static System.Transactions.TransactionScope GetNewReadUncommittedScope()
        {
            return new System.Transactions.TransactionScope(
                System.Transactions.TransactionScopeOption.RequiresNew,
                new System.Transactions.TransactionOptions
                {
                    IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted
                });
        }
    }
}