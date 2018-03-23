using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFTemplateCore.Reflection
{
    public static class TypeHelper
    {
        public  static ConcurrentDictionary<string, Type> LoadTypes(string typeName)
        {
            ConcurrentDictionary<string, Type> connectionProviders = new ConcurrentDictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesInThisAssembly) {
                if (type.GetInterface(typeName) != null) {
                    connectionProviders.TryAdd(type.Name, type);
                }
            }
            return connectionProviders;
        }
        public static Type GetTypeToCreate(string providerName, ConcurrentDictionary<string, Type> connectionProviders)
        {
            foreach (var connectionProvider in connectionProviders) {
                if (connectionProvider.Key.Contains(providerName)) {
                    return connectionProviders[connectionProvider.Key];
                }
            }
            throw new Exception(string.Format("ProviderName is not found:{0}", providerName));
        }
        public static object CreateInstance(string providerName, ConcurrentDictionary<string, Type> connectionProviders, params object[] paramArray)
        {
            Type t = TypeHelper.GetTypeToCreate(providerName, connectionProviders);
            if (t == null) {
                throw new Exception(string.Format("Provider name is not found.ProviderName:{0}", providerName));
            }
            return Activator.CreateInstance(t, args: paramArray);
        }
    }
}
