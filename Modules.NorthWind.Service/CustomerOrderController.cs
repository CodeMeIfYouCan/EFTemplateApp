using EFTemplateCore.Logging;
using EFTemplateCore.ServiceCommunicator.Security;
using EFTemplateCore.ServiceLocator;
using EFTemplateCore.TransactionManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modules.NorthWind.BusinessLogic.Transactions;
using Modules.NorthWind.DataLayer.Data;
using Modules.NorthWind.DataLayer.Data.Interfaces;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;
using System;

namespace Modules.NorthWind.Service
{

    [Route("api/[controller]")]
    public class CustomerOrderController : Controller
    {
        readonly OrderOperations orderOperations;
        readonly INorthWindTransactionalUnitOfWork unitOfWork;
        readonly ICredentialValidator credentialValidator;
        public CustomerOrderController(INorthWindTransactionalUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            orderOperations = new OrderOperations(unitOfWork);
            this.credentialValidator = CredentialValidationFactory.CreateDefaultInstance();
        }
        [HttpPost("[action]")]
        public IActionResult GetCustomerOrderDetail(CustomerOrderDetailRequest request,[FromHeader] object obj)
        {
            //try {
            //    credentialValidator.CheckCredentials(this.Request.Headers);
            //}
            //catch (Exception ex) {
            //    Services.Create<ILog>().LogFormat("Unauthorized request.Exception:{0}", LogLevel.Warning, ex);
            //    return Unauthorized();
            //}

            CustomerOrderDetailResponse response = orderOperations.GetCustomerOrderDetails(request);
            if (response == null)
                return NotFound();
            return new JsonResult(response);
        }
    }
}
