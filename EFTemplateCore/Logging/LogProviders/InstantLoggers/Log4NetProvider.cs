using log4net.Config;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Reflection;

namespace EFTemplateCore.Logging.InstantLoggers
{
    public class Log4NetProvider : ILog
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static Log4NetProvider()
        {
            var logRepository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }
        public void LogFormat(string text, LogLevel logLevel, params object[] parameters)
        {
            InternalLog(text, logLevel, parameters);
        }
        internal void InternalLog(string text, LogLevel logLevel, params object[] parameters)
        {
            if (parameters != null && parameters.Length > 0) {
                if (logLevel == LogLevel.Critical) {
                    if (parameters != null && parameters.Length > 0) {
                        log.FatalFormat(text, parameters);
                    }
                }
                else if (logLevel == LogLevel.Error) {
                    log.ErrorFormat(text, parameters);
                }
                else if (logLevel == LogLevel.Warning) {
                    log.WarnFormat(text, parameters);
                }
                else if (logLevel == LogLevel.Information) {
                    log.InfoFormat(text, parameters);
                }
                else if (logLevel == LogLevel.Debug) {
                    log.DebugFormat(text, parameters);
                }
                else if (logLevel == LogLevel.None) {
                    //Do nothing
                }
                else {
                    //LogLevel.Trace,
                    log.DebugFormat(text, parameters);
                }
            }
            else {

                if (logLevel == LogLevel.Critical) {
                    if (parameters != null && parameters.Length > 0) {
                        log.Fatal(text);
                    }
                }
                else if (logLevel == LogLevel.Error) {
                    log.Error(text);
                }
                else if (logLevel == LogLevel.Warning) {
                    log.Warn(text);
                }
                else if (logLevel == LogLevel.Information) {
                    log.Info(text);
                }
                else if (logLevel == LogLevel.Debug) {
                    log.Debug(text);
                }
                else if (logLevel == LogLevel.None) {
                    //Do nothing
                }
                else {
                    //LogLevel.Trace,
                    log.Debug(text);
                }
            }
        }
    }
}
