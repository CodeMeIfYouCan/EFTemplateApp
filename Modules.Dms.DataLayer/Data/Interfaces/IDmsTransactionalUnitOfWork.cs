using EFTemplateCore.Interfaces;

namespace Modules.Dms.DataLayer.Data.Interfaces
{
    public interface IDmsTransactionalUnitOfWork : IUnitOfWork<DmsContext>, IDmsUnitOfWork
    {
    }
}
