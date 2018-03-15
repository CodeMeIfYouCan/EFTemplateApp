

namespace EFTemplateCore.EFDbConnection
{
    public interface IEFDbConnectionProvider
    {
        string GetConnectionString();
        int GetTimeOut();
    }
}
