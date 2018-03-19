using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EFTemplateCore.EFDbConnection.JsonDbConnectionProvider
{
    public class JsonDbConnectionProvider : IEFDbConnectionProvider
    {
        IConfiguration Configuration;
        string ConnectionName;
        IConfigurationBuilder ConfigurationBuilder;
        IJsonBuildProvider JsonBuildProvider;
        public JsonDbConnectionProvider(string connectionName)
        {
            ConnectionName = connectionName;
            this.JsonBuildProvider = new JsonBuildProvider();
            ConfigurationBuilder = BuildJsonFile();
            Configuration = ConfigurationBuilder.Build();
        }
        public JsonDbConnectionProvider(string connectionName, IJsonBuildProvider jsonBuildProvider)
        {
            ConnectionName = connectionName;
            this.JsonBuildProvider = jsonBuildProvider;
            ConfigurationBuilder = JsonBuildProvider.BuildJsonFile();
            Configuration = ConfigurationBuilder.Build();
        }
        public string GetConnectionString()
        {
            return Configuration.GetConnectionString(ConnectionName);
        }
        IConfigurationBuilder BuildJsonFile()
        {
            return JsonBuildProvider.BuildJsonFile();
        }
        public T GetConnectionProperty<T>(string propertyName)
        {
            string connectionStringDetailKey = string.Concat(ConnectionName + Constants.ConnectionStringDetailsTag);
            return Configuration.GetSection(Constants.ConnectionStringsKey).GetSection(connectionStringDetailKey).GetValue<T>(propertyName);
        }
    }
}
