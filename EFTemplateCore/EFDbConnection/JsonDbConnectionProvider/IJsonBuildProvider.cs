using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection.JsonDbConnectionProvider
{
    public interface IJsonBuildProvider
    {
        IConfigurationBuilder BuildJsonFile();
    }
}
