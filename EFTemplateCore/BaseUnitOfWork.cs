
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using EFTemplateCore.Interfaces;


namespace EFTemplateCore
{
    public abstract class BaseUnitOfWork<TContext> : IUnitOfWork<TContext>, IBaseUnitOfWork where TContext : EFContext, new()
    {
        protected readonly TContext context;
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        public BaseUnitOfWork()
        {
            context = new TContext();
        }

        public BaseUnitOfWork(string connectionString)
        {
            context = (TContext)Activator.CreateInstance(typeof(TContext), connectionString);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseUnitOfWork(DbTransaction existingTransaction)
        {
            DbConnection dbConnection = existingTransaction.Connection;
            context = (TContext)Activator.CreateInstance(typeof(TContext), dbConnection);
            context.Database.UseTransaction(existingTransaction);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseUnitOfWork(DbConnection existingConnection)
        {
            context = (TContext)Activator.CreateInstance(typeof(TContext), existingConnection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseUnitOfWork(TContext context)
        {
            context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Gets the db context.
        /// </summary>
        /// <returns>The instance of type <typeparamref name="TContext"/>.</returns>
        public TContext DbContext => context;

        public IDbContextTransaction UseTransaction(DbTransaction dbTransaction)
        {
            return context.Database.UseTransaction(dbTransaction);
        }
        public IDbContextTransaction BeginTransaction()
        {
            return context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            context.Database.RollbackTransaction();
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">The disposing.</param>
        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // dispose the db context.
                    context.Dispose();
                }
            }

            disposed = true;
        }
    }
}
