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
    }
}
