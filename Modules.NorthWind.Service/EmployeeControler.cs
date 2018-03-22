using EFTemplateCore.TransactionManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.BusinessLogic.Transactions;
using Modules.NorthWind.Data;
using Modules.NorthWind.Data.Interfaces;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;

namespace Modules.NorthWind.Service
{

    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        readonly EmployeeTransactions employeeTransactions;
        readonly INorthWindTransactionaUnitOfWork unitOfWork;

        public static int HttpPost { get; private set; }

        public EmployeeController(INorthWindTransactionaUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            employeeTransactions = new EmployeeTransactions(unitOfWork);
        }

        [HttpPost("[action]")]
        public EmployeeResponse InsertEmpoloyee(EmployeeRequest request)
        {
            EmployeeResponse response = TransactionProcessor<NorthWindContext>.Execute
               (
                   employeeTransactions.InsertEmployee,
                   request,
                   unitOfWork
               );
            return response;
        }
    }
}
