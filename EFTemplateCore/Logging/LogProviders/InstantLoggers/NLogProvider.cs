using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace EFTemplateCore.Logging.LogProviders.InstantLoggers
{
    /// <summary>
    /// todo:can be implemented as a option to log4net logging
    /// </summary>
    public class NLogProvider : ILog
    {
        public void LogFormat(string txt, LogLevel logLevel, params object[] p)
        {
            throw new NotImplementedException();
        }
    }
}
