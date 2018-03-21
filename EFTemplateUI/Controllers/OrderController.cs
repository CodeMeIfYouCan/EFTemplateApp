using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTemplateCore.ServiceCommunicator;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.ViewModels;

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
            RestClient restClient = new RestClient("http://localhost:14547/api/");
            List<CustomerOrderDetailDto> test = restClient.Consume<List<CustomerOrderDetailDto>>("Test");
            return test;
        }
    }
}