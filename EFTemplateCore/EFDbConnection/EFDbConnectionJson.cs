using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection
{
    public class EFDbConnectionJson : IEFDbConnectionProvider
    {
        readonly string Code;

        public EFDbConnectionJson(string code)
        {
            Code = code;
        }

        static IConfiguration Configuration { get; set; }
        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.Build();
            return Configuration.GetConnectionString(Code);
        }

        public int GetTimeOut()
        {
            //can't take timeout from IConcfiguration.https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
            //Json format for connection string is not well designed!
            //todo:customer ConnectionString json format as in Poco converter
            throw new NotImplementedException();
        }
    }
}
