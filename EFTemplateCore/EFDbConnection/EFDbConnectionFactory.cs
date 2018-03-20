using EFTemplateCore.ServiceLocator;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace EFTemplateCore.EFDbConnection
{
    public static class EFDbConnectionFactory
    {
        //todo:static or not ? not decideded yet:)
        static ConcurrentDictionary<string, Type> connectionProviders = new ConcurrentDictionary<string, Type>();
        static string DefaultProviderName {
            get { return Services.Create<IDefaultDbProvider>().GetDefaultDbProviderName(); }
        }
        static EFDbConnectionFactory()
        {
            //todo:static constructor check!!!
            LoadTypes();
        }
        private static void LoadTypes()
        {
            connectionProviders = new ConcurrentDictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesInThisAssembly) {
                if (type.GetInterface(typeof(IEFDbConnectionProvider).ToString()) != null) {
                    connectionProviders.TryAdd(type.Name, type);
                }
            }
        }
        public static IEFDbConnectionProvider CreateInstance(string providerName, params object[] paramArray)
        {
            Type t = GetTypeToCreate(providerName);
            if (t == null) {
                throw new Exception("EFDbConnectionProvider is not found");
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
            return CreateInstance(DefaultProviderName);
        }
        /// <summary>
        /// Create Instance using JsonDefaultDbProvider. Creates instance of IEFDbConnectionProvider ctor(string connectionName)
        /// Get "DbConnectionProvider" value from appsettings.json
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static IEFDbConnectionProvider CreateDefaultInstance(string connectionName)
        {
            return CreateInstance(DefaultProviderName, connectionName);
        }
        public static Type GetTypeToCreate(string providerName)
        {
            foreach (var connectionProvider in connectionProviders) {
                if (connectionProvider.Key.Contains(providerName)) {
                    return connectionProviders[connectionProvider.Key];
                }
            }
            throw new Exception("EFDbConnectionProvider is not found");
        }
    }
    //public class EFDbConnectionFactory
    //{
    //    //todo:Emrahdi -> Make this class static!!!
    //    static Dictionary<string, Type> connectionProviders = new Dictionary<string, Type>();
    //    IConfigurationBuilder ConfigurationBuilder { get; set; }
    //    IConfigurationRoot Configuration { get; set; }
    //    IDefaultDbProvider DefaultDbProvider { get; set; }
    //    static string DefaultProviderName {
    //        get { return Services.Create<IDefaultDbProvider>().GetDefaultDbProviderName(); }
    //    }
    //    static EFDbConnectionFactory()
    //    {
    //        LoadTypes();
    //    }
    //    private static void LoadTypes()
    //    {
    //        connectionProviders = new Dictionary<string, Type>();
    //        Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
    //        foreach (Type type in typesInThisAssembly) {
    //            if (type.GetInterface(typeof(IEFDbConnectionProvider).ToString()) != null) {
    //                connectionProviders.Add(type.Name, type);
    //            }
    //        }
    //    }
    //    public IEFDbConnectionProvider CreateInstance(string providerName, params object[] paramArray)
    //    {
    //        Type t = GetTypeToCreate(providerName);
    //        if (t == null) {
    //            throw new Exception("EFDbConnectionProvider is not found");
    //        }
    //        return Activator.CreateInstance(t, args: paramArray) as IEFDbConnectionProvider;
    //    }
    //    public IEFDbConnectionProvider CreateDefaultInstance()
    //    {
    //        return CreateInstance(DefaultProviderName);
    //    }
    //    public IEFDbConnectionProvider CreateDefaultInstance(string connectionName)
    //    {
    //        return CreateInstance(DefaultProviderName, connectionName);
    //    }
    //    public Type GetTypeToCreate(string providerName)
    //    {
    //        foreach (var connectionProvider in connectionProviders) {
    //            if (connectionProvider.Key.Contains(providerName)) {
    //                return connectionProviders[connectionProvider.Key];
    //            }
    //        }
    //        throw new Exception("EFDbConnectionProvider is not found");
    //    }
    //}
}
