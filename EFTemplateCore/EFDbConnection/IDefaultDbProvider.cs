using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection
{
    public interface IDefaultDbProvider
    {
        string GetDefaultDbProviderName();
    }
}
