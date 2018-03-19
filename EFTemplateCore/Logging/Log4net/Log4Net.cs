using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.Logging.Log4net
{
    public class Log4Net : ILog
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Log4Net));
        public void Log(string text)
        {
            log.Info(text);
        }

        public void LogFormat(string text, params object[] p)
        {
            log.InfoFormat(text, p);
        }
    }
}
