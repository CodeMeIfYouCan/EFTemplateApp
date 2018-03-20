
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using EFTemplateCore.Interfaces;


namespace EFTemplateCore
{
    public abstract class UnitOfWork<TContext> : IUnitOfWork<TContext>, IBaseUnitOfWork where TContext : EFContext, new()
    {
        protected readonly TContext context;
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{TContext}"/> class.
        /// </summary>
        public UnitOfWork()
        {
            context = new TContext();
        }

        public UnitOfWork(string connectionName)
        {
            context = (TContext)Activator.CreateInstance(typeof(TContext), connectionName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(DbTransaction existingTransaction)
        {
            DbConnection dbConnection = existingTransaction.Connection;
            context = (TContext)Activator.CreateInstance(typeof(TContext), dbConnection);
            context.Database.UseTransaction(existingTransaction);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(DbConnection existingConnection)
        {
            context = (TContext)Activator.CreateInstance(typeof(TContext), existingConnection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(TContext context)
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
        /// todo:garbage collection force?
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the ef context
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
