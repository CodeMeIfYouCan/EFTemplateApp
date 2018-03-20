using EFTemplateCore.Extensions;
using Modules.NorthWind.Data;
using Modules.NorthWind.Domain.Enums;
using Modules.NorthWind.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Modules.NorthWind.BusinessLogic
{
    public class SampleBusinessCode
    {
        public List<CustomerOrderDetail> GetCustomerOrderDetails()
        {


            INorthWindUnitOfWork nUof = new NorthWindUnitOfWork();
            List<CustomerOrderDetail> result = new List<CustomerOrderDetail>();
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

            result = testQuery.Top(1000).NoLock().ToList();
            return result;
        }
    }
}
