using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection.SafeDbConnection
{
    /// <summary>
    /// Get Connection string and connection properties from a safe repository
    /// Ex: Azure Vault,HSM etc.
    /// </summary>
    class SafeDbConnectionProvider : IEFDbConnectionProvider
    {
        public T GetConnectionProperty<T>(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
