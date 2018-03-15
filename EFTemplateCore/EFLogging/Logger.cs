﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFLogging
{
    public class Logger : ILogger
    {

        readonly string categoryName;
        readonly EFLogProvider provider;
        public Logger(string categoryName, EFLogProvider provider)
        {
            this.provider = provider;
            this.categoryName = categoryName;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
            //todo:json'dan alınacak
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state,
                                Exception exception, Func<TState, Exception, string> formatter)
        {
            //grab a reference to the current logger settings for consistency, 
            //and to eliminate the need to block a thread reconfiguring the logger
            if (!IsEnabled(logLevel)) {
                return;
            }
            var config = provider.Configuration;
            if (config.Filter(categoryName, logLevel)) {
                config.Logger(formatter(state, exception));
            }
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
    }
}
