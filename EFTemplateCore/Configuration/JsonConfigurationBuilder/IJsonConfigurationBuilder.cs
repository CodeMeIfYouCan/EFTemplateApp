using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.Configuration.JsonConfigurationBuilder
{
    /// <summary>
    /// Added for unit testing the configuration builder of json file
    /// </summary>
    public interface IJsonConfigurationBuilder
    {
        IConfigurationBuilder BuildJsonFile();
    }
}
