

namespace EFTemplateCore.EFDbConnection
{
    public interface IEFDbConnectionProvider
    {
        string GetConnectionString();
        T GetConnectionProperty<T>(string propertyName);
    }
}
