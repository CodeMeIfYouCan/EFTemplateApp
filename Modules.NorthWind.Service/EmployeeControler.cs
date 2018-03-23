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
        readonly INorthWindTransactionalUnitOfWork unitOfWork;

        public static int HttpPost { get; private set; }

        public EmployeeController(INorthWindTransactionalUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            employeeTransactions = new EmployeeTransactions(unitOfWork);
        }

        //todo:turenc-FromBody-->https://stackoverflow.com/questions/24625303/why-do-we-have-to-specify-frombody-and-fromuri
        [HttpPost("[action]")]
        public IActionResult InsertEmpoloyee([FromBody] EmployeeRequest request)
        {
            EmployeeResponse response = TransactionProcessor<NorthWindContext>.Execute
               (
                   employeeTransactions.InsertEmployee,
                   request,
                   unitOfWork
               );
            return new JsonResult(response);
        }
    }
}
