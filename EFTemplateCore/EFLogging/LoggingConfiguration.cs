using Microsoft.Extensions.Logging;
using System;

namespace EFTemplateCore.EFLogging
{
    /// <summary>
    /// Logging configuration class.
    /// </summary>
    public class LoggingConfiguration
    {
        public readonly Action<string> Logger;
        public readonly Func<string, LogLevel, bool> Filter;
        public LoggingConfiguration(Action<string> logger, Func<string, LogLevel, bool> filter)
        {
            Logger = logger;
            Filter = filter;
        }
    }
}
