using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Common;

namespace EFTemplateCore.Interfaces
{
    /// <summary>
    /// Unit of work interface.
    /// todo:partial?
    /// </summary>
    public partial interface IBaseUnitOfWork : IDisposable
    {
        IDbContextTransaction UseTransaction(DbTransaction dbTransaction);
        IDbContextTransaction BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
