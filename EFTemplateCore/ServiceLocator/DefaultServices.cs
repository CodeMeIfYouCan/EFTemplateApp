using EFTemplateCore.EFDbConnection;
using EFTemplateCore.EFDbConnection.JsonDbConnection;

namespace EFTemplateCore.ServiceLocator
{
    public class DefaultServices
    {
        public static void RegisterDefaultServices()
        {
            Services.Register<IDefaultDbProvider>(new JsonDefaultDbProvider());
        }
    }
}
