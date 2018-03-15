using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;

namespace EFTemplateCore.EFLogging
{

    public class EFLogProvider : ILoggerProvider
    {
        //volatile to allow the configuration to be switched without locking
        public volatile LoggingConfiguration Configuration;
        static bool DefaultFilter(string CategoryName, LogLevel level) => true;

        static ConcurrentDictionary<Type, EFLogProvider> providers = new ConcurrentDictionary<Type, EFLogProvider>();

        public static void CreateOrModifyLoggerForDbContext(Type DbContextType,
                                                            ILoggerFactory loggerFactory,
                                                            Action<string> logger,
                                                            Func<string, LogLevel, bool> filter = null)
        {
            bool isNew = false;
            var provider = providers.GetOrAdd(DbContextType, t =>
            {
                var p = new EFLogProvider(logger, filter ?? DefaultFilter);
                loggerFactory.AddProvider(p);
                isNew = true;
                return p;
            }
              );
            if (!isNew)
            {
                provider.Configuration = new LoggingConfiguration(logger, filter ?? DefaultFilter);
            }

        }

        public EFLogProvider(Action<string> logger, Func<string, LogLevel, bool> filter)
        {
            this.Configuration = new LoggingConfiguration(logger, filter);
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new Logger(categoryName, this);
        }

        public void Dispose()
        {
            //providers.Clear();
            //this.Configuration = null;
        }
    }
}
