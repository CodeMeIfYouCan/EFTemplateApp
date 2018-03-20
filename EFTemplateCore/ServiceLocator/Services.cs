using System;
using System.Collections.Generic;

namespace EFTemplateCore.ServiceLocator {
    public delegate object ServiceProvider();

    public static class Services {
        static readonly IDictionary<Type, ServiceProvider> Providers = new Dictionary<Type, ServiceProvider>();
        static object sync = new object();
        public static void RegisterIfNotRegistered<T, C>() {
            if (!IsRegistered(typeof(T))) {
                Register<T, C>();
            }
        }
        public static void Register<T>(ServiceProvider provider) {
            Providers[typeof(T)] = provider;
        }

        public static void Register<T>(object instance) {
            Providers[typeof(T)] = (() => instance);
        }

        public static void Register<T, C>() {
            Providers[typeof(T)] = DefaultProvider<C>;
        }

        static object DefaultProvider<C>() {
            return Activator.CreateInstance<C>();
        }

        public static bool IsRegistered(Type type) {
            return Providers.ContainsKey(type);
        }

        public static T Create<T>() {
            Type type = typeof(T);
            if (!Providers.ContainsKey(type)) {
                throw new Exception(string.Format("Unable to find service {0}. Please check if application is started correctly.",
                    type));
            }
            ServiceProvider serviceProvider = Providers[type];
            return (T)serviceProvider();
        }

        internal static void Clear() {
            Providers.Clear();
        }
    }
}