using Microsoft.EntityFrameworkCore.ChangeTracking;
using Modules.NorthWind.Data;
using Modules.NorthWind.ViewModels.DataTransferObjects;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;
using EFTemplateCore.ModelMapper;
using Modules.NorthWind.Domain;

namespace Modules.NorthWind.BusinessLogic.Transactions
{
    public class EmployeeTransactions
    {
        readonly INorthWindUnitOfWork northWindUnitOfWork;
        public EmployeeTransactions(INorthWindUnitOfWork northWindUnitOfWork)
        {
            this.northWindUnitOfWork = northWindUnitOfWork;
        }
        public EmployeeResponse InsertEmployee(EmployeeRequest request)
        {
            EmployeeResponse response = new EmployeeResponse();
            EmployeeDto employeeDto = request.EmployeeDto;
            EmployeeRepository employeeRepository = northWindUnitOfWork.EmployeeRepository;
            EntityEntry<Employee> employee = employeeRepository.Add(employeeDto.ToEntity<EmployeeDto, Employee>());
            response.EmployeeId = employee.Entity.EmployeeId;
            return response;
        }
    }
}
