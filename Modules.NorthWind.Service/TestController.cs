﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.BusinessLogic;
using Modules.NorthWind.ViewModels;

namespace Modules.NorthWind.Service
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        SampleBusinessCode sampleBusinessCode = new SampleBusinessCode();
        // GET api/values
        [HttpGet]
        public List<CustomerOrderDetailDto> Get()
        {
            List<CustomerOrderDetailDto> result = sampleBusinessCode.GetCustomerOrderDetails();
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
