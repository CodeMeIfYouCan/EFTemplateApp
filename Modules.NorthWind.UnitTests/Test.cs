﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modules.NorthWind.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFTemplateCore.Extensions;

namespace Modules.NorthWind.UnitTests
{
    [TestClass]
    public class Test
    {
        [TestMethod()]
        public void Test1()
        {
            IUnitOfWork unitOfWork = new UnitOfWork("server=S0134DBTEMP; user=quantra; password=quantra2; database=NorthWindDatabase; pooling=true; Max Pool Size=100; Min Pool Size=8");

            CustomerRepository customers = unitOfWork.CustomerRepository;
            OrderRepository orders = unitOfWork.OrderRepository;
            OrderDetailRepository orderDetails = unitOfWork.OrderDetailRepository;
            ProductRepository products = unitOfWork.ProductRepository;

            var testQuery = from c in customers.Table()
                            join o in orders.Table() on c.CustomerId equals o.CustomerId
                            join od in orderDetails.Table() on o.OrderId equals od.OrderId
                            join p in products.Table() on od.ProductId equals p.ProductId
                            where p.CategoryId.Value > 1
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
            Assert.IsTrue(1 == 1);
        }
        
        public class CustomerOrderDetail
        {
            public int OrderId { get; set; } // OrderID (Primary key)
            public int ProductId { get; set; } // ProductID (Primary key)
            public string ProductName { get; set; } // ProductName (length: 40)
            public decimal UnitPrice { get; set; } // UnitPrice
            public short Quantity { get; set; } // Quantity
            public float Discount { get; set; } // Discount
            public string CompanyName { get; set; } // CompanyName (length: 40)
            public string ContactName { get; set; } // ContactName (length: 30)
            public string Phone { get; set; } // Phone (length: 24)
            public DateTime? OrderDate { get; set; } // OrderDate        
            public DateTime? RequiredDate { get; set; } // RequiredDate
            public DateTime? ShippedDate { get; set; } // ShippedDate
        }
    }
}
