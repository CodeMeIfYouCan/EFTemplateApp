using EFTemplateCore.Configuration.JsonConfigurationBuilder;
using EFTemplateCore.EFDbConnection.JsonDbConnection;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace EFTemplateCore.UnitTests
{
    [TestClass]
    public class DbConnectiontests
    {
        public static string GetConnectionStringForTest()
        {
            var mockDependency = new Mock<IJsonConfigurationBuilder>();
            var dict = new Dictionary<string, string> { { "ConnectionStrings:NorthWindConnection", "server=s0134dbtemp; user=quantra; password=quantra2; database=NorthWindDatabase; pooling=true; Max Pool Size=100; Min Pool Size=8" } };
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(dict);
            mockDependency.Setup(x => x.BuildJsonFile())
                          .Returns(builder);
            JsonDbConnectionProvider provider = new JsonDbConnectionProvider("NorthWindConnection", mockDependency.Object);
            var connectionString = provider.GetConnectionString();
            return connectionString;
        }
        [TestMethod]
        public void TestConnectionString()
        {
            var connectionString = GetConnectionStringForTest();
            Assert.AreEqual(connectionString, "test");
        }
        [TestMethod]
        public void TestConnectionDetails()
        {
            var mockDependency = new Mock<IJsonConfigurationBuilder>();
            var dict = new Dictionary<string, string> { { "ConnectionStrings:NorthWindConnectionDetails:CommandTimeout", "100" } };
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(dict);
            mockDependency.Setup(x => x.BuildJsonFile())
                          .Returns(builder);
            JsonDbConnectionProvider provider = new JsonDbConnectionProvider("NorthWindConnection", mockDependency.Object);
            var commandTimeout = provider.GetConnectionProperty<int>("CommandTimeout");
            Assert.AreEqual(commandTimeout, 100);
        }
    }
}
 