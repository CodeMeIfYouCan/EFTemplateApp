using EFTemplateCore.Configuration.JsonConfigurationBuilder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EFTemplateCore.EFDbConnection.JsonDbConnection
{
    /// <summary>
    /// Gets db connection string and other connection properties
    /// from json configuration file.
    /// </summary>
    public class JsonDbConnectionProvider : IEFDbConnectionProvider
    {
        IConfigurationRoot Configuration { get; set; }
        string ConnectionName { get; set; }
        IConfigurationBuilder ConfigurationBuilder { get; set; }
        IJsonConfigurationBuilder JsonConfigurationBuilder { get; set; }
        /// <summary>
        /// Ctor for getting default connection string
        /// </summary>
        public JsonDbConnectionProvider()
        {
            BuildConfigurationFile();
            ConnectionName = Configuration.GetSection(Constants.ConnectionStringsKey).GetValue<string>(Constants.DefaultConnectionName);
        }
        public JsonDbConnectionProvider(string connectionName)
        {
            BuildConfigurationFile();
            ConnectionName = connectionName;
        }
        public JsonDbConnectionProvider(string connectionName, IJsonConfigurationBuilder jsonBuildProvider)
        {
            ConnectionName = connectionName;
            this.JsonConfigurationBuilder = jsonBuildProvider;
            ConfigurationBuilder = JsonConfigurationBuilder.BuildJsonFile();
            Configuration = ConfigurationBuilder.Build();
        }
        void BuildConfigurationFile()
        {
            this.JsonConfigurationBuilder = new JsonConfigurationBuilder();
            ConfigurationBuilder = BuildJsonFile();
            Configuration = ConfigurationBuilder.Build();
        }
        public string GetConnectionString()
        {
            return Configuration.GetConnectionString(ConnectionName);
        }
        IConfigurationBuilder BuildJsonFile()
        {
            return JsonConfigurationBuilder.BuildJsonFile();
        }
        public T GetConnectionProperty<T>(string propertyName)
        {
            string connectionStringDetailKey = string.Concat(ConnectionName + Constants.ConnectionStringDetailsTag);
            return Configuration.GetSection(Constants.ConnectionStringsKey).GetSection(connectionStringDetailKey).GetValue<T>(propertyName);
        }
    }
}
