using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTemplateCore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.BusinessLogic;
using Modules.NorthWind.Data;
using Modules.NorthWind.Domain.Enums;
using Modules.NorthWind.ViewModels;

namespace Modules.NorthWind.Service
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        SampleBusinessCode sampleBusinessCode = new SampleBusinessCode();
        // GET api/values
        [HttpGet]
        public List<CustomerOrderDetail> Get()
        {
            List<CustomerOrderDetail> result = sampleBusinessCode.GetCustomerOrderDetails();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
