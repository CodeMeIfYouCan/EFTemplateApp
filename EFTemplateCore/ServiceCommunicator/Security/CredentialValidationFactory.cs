using EFTemplateCore.Configuration.JsonConfigurationBuilder;
using EFTemplateCore.Logging;
using EFTemplateCore.Reflection;
using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;


namespace EFTemplateCore.ServiceCommunicator.Security
{
    public static class CredentialValidationFactory
    {
        static ConcurrentDictionary<string, Type> validationProviders = new ConcurrentDictionary<string, Type>();
        static readonly string DefaultProviderName;
        static CredentialValidationFactory()
        {
            try {
                LoadTypes();
                var configuration = Services.Create<IJsonConfigurationBuilder>().BuildJsonFile().Build();
                DefaultProviderName = configuration.GetValue<string>(Constants.DefaultCredentialProviderKey);
            }
            catch (Exception ex) {
                Services.Create<ILog>().LogFormat("Exception in CredentialValidationFactory LoadingTypes! Exception:{0}", LogLevel.Critical, ex);
            }
        }
        private static void LoadTypes()
        {
            validationProviders = TypeHelper.LoadTypes(typeof(ICredentialValidator).Name);
        }
        public static ICredentialValidator CreateInstance(string providerName, params object[] paramArray)
        {
            Type t = TypeHelper.GetTypeToCreate(providerName, validationProviders);
            if (t == null) {
                throw new Exception(string.Format("CredentialValidationProvider is not found!Provider Name:{0}", providerName));
            }
            return Activator.CreateInstance(t, args: paramArray) as ICredentialValidator;
        }
        /// <summary>
        /// Create Instance using JsonDefaultDbProvider.Creates instance of IEFDbConnectionProvider ctor()
        /// Get "CredentialProvider" value from appsettings.json
        /// </summary>
        /// <returns></returns>
        public static ICredentialValidator CreateDefaultInstance()
        {
            return TypeHelper.CreateInstance(DefaultProviderName, validationProviders) as ICredentialValidator;
        }
        /// <summary>
        /// Create Instance using JsonDefaultDbProvider. Creates instance of ICredentialValidator ctor(string userName, string password)
        /// Get "CredentialProvider" value from appsettings.json
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static ICredentialValidator CreateDefaultInstance(string userName, string password)
        {
            return TypeHelper.CreateInstance(DefaultProviderName, validationProviders, userName, password) as ICredentialValidator;
        }
    }
}
