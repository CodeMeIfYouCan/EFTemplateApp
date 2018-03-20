using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace EFTemplateCore.Configuration.JsonConfigurationBuilder
{
    public class JsonConfigurationBuilder : IJsonConfigurationBuilder
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
