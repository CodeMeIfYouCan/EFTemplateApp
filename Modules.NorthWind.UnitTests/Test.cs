using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using EFTemplateCore.Extensions;
using Modules.NorthWind.ViewModels.DataTransferObjects;
using Modules.NorthWind.DataLayer;
using Modules.NorthWind.BusinessLogic.Transactions;
using Modules.NorthWind.ViewModels.Request;
using System;
using Modules.NorthWind.ViewModels.Response;
using EFTemplateCore.TransactionManager;
using EFTemplateCore.ServiceLocator;
using Modules.NorthWind.Service;
using Microsoft.AspNetCore.Mvc;

namespace Modules.NorthWind.UnitTests
{
    [TestClass]
    public class Test
    {
        NorthWindUnitOfWork northWindUnitOfWork = FakeNorthWindUnitOfWork.Get();

        //CUSTOM TEST 
        [TestMethod()]
        public void CustomTest()
        {
            DefaultServices.RegisterDefaultServices();
            CustomerRepository customers = northWindUnitOfWork.CustomerRepository;
            OrderRepository orders = northWindUnitOfWork.OrderRepository;
            OrderDetailRepository orderDetails = northWindUnitOfWork.OrderDetailRepository;
            ProductRepository products = northWindUnitOfWork.ProductRepository;

            EmployeeRepository employeeRepository = northWindUnitOfWork.EmployeeRepository;
            employeeRepository.Add(new Employee { FirstName = "Emrah", LastName = "Dinçadam" });
            employeeRepository.Add(new Employee { FirstName = "Türenç", LastName = "Engin" });

            var employe = employeeRepository.Table().ToList();
            Assert.AreEqual(employe.Count(), 2);

            var testQuery = from c in customers.Table()
                            join o in orders.Table() on c.CustomerId equals o.CustomerId
                            join od in orderDetails.Table() on o.OrderId equals od.OrderId
                            join p in products.Table() on od.ProductId equals p.ProductId
                            //where c.CustomerType == CustomerType.Individual
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
            Assert.AreEqual(customerOrderDetails.Count(), 0);
        }

        //BLL TEST 
        [TestMethod()]
        public void BllTest()
        {
            DefaultServices.RegisterDefaultServices();
            EmployeeTransactions employeeTransactions = new EmployeeTransactions(northWindUnitOfWork);
            EmployeeRequest employeeRequest = new EmployeeRequest()
            {
                EmployeeDto = new EmployeeDto()
                {
                    EmployeeId = 0,
                    LastName = "Emrah",
                    FirstName = "Dinçadam",
                    Title = "Emrah Dinçadam",
                    TitleOfCourtesy = "ED",
                    BirthDate = new DateTime(1986, 07, 14),
                    HireDate = new DateTime(2018, 01, 15),
                    Address = "Sanayi Mahallesi, Teknopark Bulvarı 1/3C Kurtköy - Pendik",
                    City = "İstanbul",
                    Region = "Anadolu",
                    PostalCode = "34906",
                    Country = "Türkiye",
                    HomePhone = "+90 216 664 20 00",
                    Extension = "",
                    Photo = null,
                    Notes = "Developer",
                    ReportsTo = null,
                    PhotoPath = ""
                }
            };

            EmployeeResponse response = TransactionProcessor<NorthWindContext>.Execute
              (
                  employeeTransactions.InsertEmployee,
                  employeeRequest,
                  northWindUnitOfWork
              );
                       
            OrderOperations orderOperations = new OrderOperations(northWindUnitOfWork);
            var customerOrderDetail = orderOperations.GetCustomerOrderDetails(new CustomerOrderDetailRequest() { CustomerId = 1 });
        }

        //SERVICE TEST 
        [TestMethod()]
        public void ServiceTest()
        {
            DefaultServices.RegisterDefaultServices();
            EmployeeController employeeController = new EmployeeController(northWindUnitOfWork);
            EmployeeRequest employeeRequest = new EmployeeRequest()
            {
                EmployeeDto = new EmployeeDto()
                {
                    EmployeeId = 0,
                    LastName = "Türenç",
                    FirstName = "Engin",
                    Title = "Türenç Engin",
                    TitleOfCourtesy = "TE",
                    BirthDate = new DateTime(1986, 07, 14),
                    HireDate = new DateTime(2018, 01, 15),
                    Address = "Sanayi Mahallesi, Teknopark Bulvarı 1/3C Kurtköy - Pendik",
                    City = "İstanbul",
                    Region = "Anadolu",
                    PostalCode = "34906",
                    Country = "Türkiye",
                    HomePhone = "+90 216 664 20 00",
                    Extension = "",
                    Photo = null,
                    Notes = "Developer",
                    ReportsTo = null,
                    PhotoPath = ""
                }
            };

            IActionResult result = employeeController.InsertEmpoloyee(employeeRequest);
            if (result is JsonResult)
            {
                JsonResult jsonResult = (JsonResult)result;
                if (jsonResult.Value is EmployeeResponse)
                {
                    EmployeeResponse employeeResponse = (EmployeeResponse)jsonResult.Value;
                }
            }
        }
    }
}
