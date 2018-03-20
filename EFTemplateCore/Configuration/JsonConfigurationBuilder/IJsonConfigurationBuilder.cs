using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.Configuration.JsonConfigurationBuilder
{
    public interface IJsonConfigurationBuilder
    {
        IConfigurationBuilder BuildJsonFile();
    }
}
