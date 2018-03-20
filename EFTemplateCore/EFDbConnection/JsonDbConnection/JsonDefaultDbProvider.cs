using EFTemplateCore.Configuration.JsonConfigurationBuilder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection.JsonDbConnection
{
    public class JsonDefaultDbProvider : IDefaultDbProvider
    {
        IConfigurationBuilder ConfigurationBuilder { get; set; }
        IConfigurationRoot Configuration { get; set; }
        public string GetDefaultDbProviderName()
        {
            JsonConfigurationBuilder builder = new JsonConfigurationBuilder();
            ConfigurationBuilder = builder.BuildJsonFile();
            ConfigurationBuilder.Build();
            Configuration = ConfigurationBuilder.Build();
            return Configuration.GetValue<string>(Constants.DbConnectionProvider);
        }
    }
}
