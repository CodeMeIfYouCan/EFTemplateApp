

namespace EFTemplateCore.Securtiy
{
    /// <summary>
    /// Internal helper class for getting db connection from a secure source. Hsm,custom encrpyted module etc.
    /// </summary>
    internal class SafeUtilities
    {
        

        //internal static void SetConnectionString(EFContext context)
        //{
        //    var connection = SqlInterSafeService.Instance.GetDatabaseConnection(GetSafeCode());
        //    context.Database.Connection.ConnectionString = connection.ConnectionString;

        //}
        //internal static string GetSafeCode()
        //{
        //    if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["DefaultSafeCode"]))
        //        return ConfigurationManager.AppSettings["DefaultSafeCode"];
        //    return ForaConstants.InterSafeDefaultSafeCode;
        //}
    }
}
