

using EFTemplateCore.TransactionManager;

namespace Modules.NorthWind.ViewModels.Response
{
    public class EmployeeResponse : BaseResponseMessage
    {
        public int EmployeeId { get; set; } // OrderID (Primary key)
    }
}
