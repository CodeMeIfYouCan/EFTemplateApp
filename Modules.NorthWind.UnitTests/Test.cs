using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modules.NorthWind.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFTemplateCore.Extensions;
using Modules.NorthWind.Domain.Enums;
using Modules.NorthWind.ViewModels;

namespace Modules.NorthWind.UnitTests
{
    [TestClass]
    public class Test
    {
        [TestMethod()]
        public void Test1()
        {
            INorthWindUnitOfWork unitOfWork = new NorthWindUnitOfWork("server=S0134DBTEMP; user=quantra; password=quantra2; database=NorthWindDatabase; pooling=true; Max Pool Size=100; Min Pool Size=8");

            CustomerRepository customers = unitOfWork.CustomerRepository;
            OrderRepository orders = unitOfWork.OrderRepository;
            OrderDetailRepository orderDetails = unitOfWork.OrderDetailRepository;
            ProductRepository products = unitOfWork.ProductRepository;

            var testQuery = from c in customers.Table()
                            join o in orders.Table() on c.CustomerId equals o.CustomerId
                            join od in orderDetails.Table() on o.OrderId equals od.OrderId
                            join p in products.Table() on od.ProductId equals p.ProductId
                            where c.CustomerType == CustomerType.Individual
                            orderby o.OrderId descending
                            orderby c.CompanyName ascending
                            select new CustomerOrderDetailDto()
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
            List<CustomerOrderDetailDto> customerOrderDetails = testQuery.Top(1000).NoLock().ToList();
            Assert.IsTrue(1 == 1);
        }
        
    }
}
