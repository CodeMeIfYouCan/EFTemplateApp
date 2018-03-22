using Microsoft.EntityFrameworkCore.ChangeTracking;
using Modules.NorthWind.Data;
using Modules.NorthWind.ViewModels.Model;
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
            EmployeeResponse response = new EmployeeResponse();
            EmployeeDto employeeDto = request.EmployeeDto;
            
            EmployeeRepository employeeRepository = northWindUnitOfWork.EmployeeRepository;
            EntityEntry<Domain.Employee> employee = employeeRepository.Add(new Domain.Employee()
            {
                EmployeeId = employeeDto.EmployeeId,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Title = employeeDto.Title,
                TitleOfCourtesy = employeeDto.TitleOfCourtesy,
                BirthDate = employeeDto.BirthDate,
                HireDate = employeeDto.HireDate,
                Address = employeeDto.Address,
                City = employeeDto.City,
                Region = employeeDto.Region,
                PostalCode = employeeDto.PostalCode,
                Country = employeeDto.Country,
                HomePhone = employeeDto.HomePhone,
                Extension = employeeDto.Extension,
                Photo = employeeDto.Photo,
                Notes = employeeDto.Notes,
                ReportsTo = employeeDto.ReportsTo,
                PhotoPath = employeeDto.PhotoPath
            });
            response.EmployeeId = employee.Entity.EmployeeId;
            return response;
        }
    }
}
