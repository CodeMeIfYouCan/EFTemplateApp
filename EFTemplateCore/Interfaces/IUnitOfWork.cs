using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Common;

namespace EFTemplateCore.Interfaces
{
    /// <summary>
    /// Definition of the interface for unit of work.
    /// </summary>
    public partial interface IBaseUnitOfWork : IDisposable
    {
        IDbContextTransaction UseTransaction(DbTransaction dbTransaction);

        IDbContextTransaction BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        /// <summary>
        /// Gets the specified repository for the <typeparamref name="TEntity"/>.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>An instance of type inherited from <see cref="IRepository{TEntity}"/> interface.</returns>
        IRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class, IEntity, new();
    }
}
