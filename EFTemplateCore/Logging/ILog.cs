using Microsoft.Extensions.Logging;


namespace EFTemplateCore.Logging
{
    public interface ILog
    {
        void LogFormat(string txt, LogLevel logLevel, params object[] p);
    }
}
