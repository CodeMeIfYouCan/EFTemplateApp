using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection
{
    /// <summary>
    /// Gets the source of the DbProvider properties.Provider Name etc.
    /// </summary>
    public interface IDefaultDbProvider
    {
        string GetDefaultDbProviderName();
    }
}
