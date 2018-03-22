using EFTemplateCore.TransactionManager;
using Modules.NorthWind.ViewModels.Model;

namespace Modules.NorthWind.ViewModels.Request
{
    public class EmployeeRequest: BaseRequestMessage
    {
        public EmployeeDto EmployeeDto { get; set; }
    }
}
