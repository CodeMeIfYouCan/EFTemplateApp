using EFTemplateCore.Logging;
using EFTemplateCore.Reflection;
using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace EFTemplateCore.EFDbConnection
{
    public static class EFDbConnectionFactory
    {
        static ConcurrentDictionary<string, Type> connectionProviders = new ConcurrentDictionary<string, Type>();
        static string DefaultProviderName {
            get { return Services.Create<IDefaultDbProvider>().GetDefaultDbProviderName(); }
        }
        static EFDbConnectionFactory()
        {
            try {
                LoadTypes();
            }
            catch (Exception ex) {
                Services.Create<ILog>().LogFormat("Exception in EFDbConnectionFactory LoadingTypes! Exception:{0}", LogLevel.Critical, ex);
            }
        }
        private static void LoadTypes()
        {
            connectionProviders = TypeHelper.LoadTypes(typeof(IEFDbConnectionProvider).Name);
        }
        public static IEFDbConnectionProvider CreateInstance(string providerName, params object[] paramArray)
        {
            Type t = TypeHelper.GetTypeToCreate(providerName, connectionProviders);
            if (t == null) {
                throw new Exception(string.Format("EFDbConnectionProvider is not found!Provider Name:{0}", providerName));
            }
            return Activator.CreateInstance(t, args: paramArray) as IEFDbConnectionProvider;
        }
        /// <summary>
        /// Create Instance using JsonDefaultDbProvider.Creates instance of IEFDbConnectionProvider ctor()
        /// Get "DbConnectionProvider" value from appsettings.json
        /// </summary>
        /// <returns></returns>
        public static IEFDbConnectionProvider CreateDefaultInstance()
        {
            return TypeHelper.CreateInstance(DefaultProviderName, connectionProviders) as IEFDbConnectionProvider;
        }
        /// <summary>
        /// Create Instance using JsonDefaultDbProvider. Creates instance of IEFDbConnectionProvider ctor(string connectionName)
        /// Get "DbConnectionProvider" value from appsettings.json
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static IEFDbConnectionProvider CreateDefaultInstance(string connectionName)
        {
            return TypeHelper.CreateInstance(DefaultProviderName, connectionProviders, connectionName) as IEFDbConnectionProvider;
        }
    }
}
