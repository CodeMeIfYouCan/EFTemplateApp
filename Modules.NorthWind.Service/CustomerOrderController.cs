using EFTemplateCore.TransactionManager;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.BusinessLogic.Transactions;
using Modules.NorthWind.Data;
using Modules.NorthWind.Data.Interfaces;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;

namespace Modules.NorthWind.Service
{

    [Route("api/[controller]")]
    public class CustomerOrderController : Controller
    {
        readonly OrderOperations orderOperations;
        readonly INorthWindTransactionalUnitOfWork unitOfWork;
        public CustomerOrderController(INorthWindTransactionalUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            orderOperations = new OrderOperations(unitOfWork);
        }
        [HttpPost("[action]")]
        public CustomerOrderDetailResponse GetCustomerOrderDetail(CustomerOrderDetailRequest request)
        {
            CustomerOrderDetailResponse response = orderOperations.GetCustomerOrderDetails(request);
            return response;
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
