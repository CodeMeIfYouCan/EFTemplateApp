using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTemplateCore.ServiceCommunicator;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.ViewModels;
using Modules.NorthWind.ViewModels.DataTransferObjects;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;

namespace EFTemplateUI.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IEnumerable<CustomerOrderDetailDto> GetCustomerOrderDetail()
        {
            CustomerOrderDetailRequest customerOrderDetailRequest = new CustomerOrderDetailRequest();
            customerOrderDetailRequest.CustomerId = 24325;
            RestClient restClient = new RestClient("http://localhost:14547/api/");
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            List<CustomerOrderDetailDto> customerOrder = restClient.Consume<CustomerOrderDetailResponse>("CustomerOrder/GetCustomerOrderDetail", "POST", customerOrderDetailRequest, userInfo).CustomerOrderDetails;
            return customerOrder;
        }
    }
}