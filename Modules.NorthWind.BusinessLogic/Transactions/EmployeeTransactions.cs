using Modules.NorthWind.Data;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;
using System.Collections.Generic;

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
            var employeeRepository = northWindUnitOfWork.EmployeeRepository;
            EmployeeResponse response = new EmployeeResponse();
            var insertedResult=employeeRepository.Add(new Domain.Employee() { FirstName = request.EmployeeDto.FirstName, LastName = request.EmployeeDto.LastName });
            response.EmployeeId = response.EmployeeId;
            return response;
        }
    }
}
