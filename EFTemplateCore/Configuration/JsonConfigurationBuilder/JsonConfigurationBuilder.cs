using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace EFTemplateCore.Configuration.JsonConfigurationBuilder
{
    /// <summary>
    /// Default configuration builder for json configuration file,
    /// appsettings.json
    /// </summary>
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
            return Constants.JsonAppsettingsFile;
        }
        string GetJsonFilePath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
