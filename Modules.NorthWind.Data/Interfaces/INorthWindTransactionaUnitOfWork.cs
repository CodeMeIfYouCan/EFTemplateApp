using EFTemplateCore.Interfaces;
using Modules.NorthWind.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.NorthWind.Data.Interfaces
{
    public interface INorthWindTransactionaUnitOfWork: IUnitOfWork<NorthWindContext>, INorthWindUnitOfWork
    {
    }
}
