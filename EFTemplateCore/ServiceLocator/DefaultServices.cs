using EFTemplateCore.Configuration.JsonConfigurationBuilder;
using EFTemplateCore.EFDbConnection;
using EFTemplateCore.EFDbConnection.JsonDbConnection;
using EFTemplateCore.Logging;
using EFTemplateCore.Logging.InstantLoggers;

namespace EFTemplateCore.ServiceLocator
{
    public class DefaultServices
    {
        public static void RegisterDefaultServices()
        {
            Services.Register<IDefaultDbProvider>(new JsonDefaultDbProvider());
            Services.Register<IJsonConfigurationBuilder>(new JsonConfigurationBuilder());
            Services.Register<ILog>(new Log4NetProvider());
        }

    }
}
