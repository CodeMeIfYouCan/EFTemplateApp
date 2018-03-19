using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace EFTemplateCore.EFDbConnection.JsonDbConnectionProvider
{
    public class JsonBuildProvider : IJsonBuildProvider
    {
        public IConfigurationBuilder BuildJsonFile()
        {
            return new ConfigurationBuilder()
                .SetBasePath(GetJsonFilePath())
                .AddJsonFile(GetJsonFile());
        }
        string GetJsonFile()
        {
            return "appsettings.json";
        }
        string GetJsonFilePath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
