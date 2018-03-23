using EFTemplateCore.Interfaces;

namespace Modules.NorthWind.DataLayer.Data.Interfaces
{
    public interface INorthWindTransactionalUnitOfWork: IUnitOfWork<NorthWindContext>, INorthWindUnitOfWork
    {
    }
}
