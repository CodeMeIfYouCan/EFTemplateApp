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
            //todo:Register ILog interface using the name of the provider.
            //Take the provider name from appsettings.json file
            Services.Register<ILog>(new Log4NetProvider());
        }

    }
}
