using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.Logging
{
    interface ILog
    {
        void Log(string txt);
        void LogFormat(string txt, params object[] p);
    }
}
