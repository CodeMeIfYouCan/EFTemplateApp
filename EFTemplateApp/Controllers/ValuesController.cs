using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTemplateCore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Modules.NorthWind.Data;
using Modules.NorthWind.Domain.Enums;
using static Modules.NorthWind.UnitTests.Test;

namespace EFTemplateApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        readonly INorthWindUnitOfWork nUof;
        public ValuesController(INorthWindUnitOfWork unitOfWork)
        {
            this.nUof = unitOfWork;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            CustomerRepository customers = nUof.CustomerRepository;
            OrderRepository orders = nUof.OrderRepository;
            OrderDetailRepository orderDetails = nUof.OrderDetailRepository;
            ProductRepository products = nUof.ProductRepository;

            var testQuery = from c in customers.AsQueryable()
                            join o in orders.Table() on c.CustomerId equals o.CustomerId
                            join od in orderDetails.Table() on o.OrderId equals od.OrderId
                            join p in products.Table() on od.ProductId equals p.ProductId
                            where c.CustomerType == CustomerType.Individual
                            orderby o.OrderId descending
                            orderby c.CompanyName ascending
                            select new CustomerOrderDetail()
                            {
                                OrderId = o.OrderId,
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                UnitPrice = od.UnitPrice,
                                Quantity = od.Quantity,
                                Discount = od.Discount,
                                CompanyName = c.CompanyName,
                                ContactName = c.ContactName,
                                Phone = c.Phone,
                                OrderDate = o.OrderDate,
                                RequiredDate = o.RequiredDate,
                                ShippedDate = o.ShippedDate
                            };
            try
            {
                List<CustomerOrderDetail> customerOrderDetails = testQuery.Top(1000).NoLock().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

            return new string[] { "value1", "value2" };
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
