using Modules.NorthWind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTemplateApp.BusinessLogicLayer
{
    //public class SampleBusinessCode : BaseBusinessLogic
    //{
    //    CustomerRepository customers = unitOfWork.CustomerRepository;
    //    OrderRepository orders = unitOfWork.OrderRepository;
    //    OrderDetailRepository orderDetails = unitOfWork.OrderDetailRepository;
    //    ProductRepository products = unitOfWork.ProductRepository;

    //    var testQuery = from c in customers.Table()
    //                    join o in orders.Table() on c.CustomerId equals o.CustomerId
    //                    join od in orderDetails.Table() on o.OrderId equals od.OrderId
    //                    join p in products.Table() on od.ProductId equals p.ProductId
    //                    where c.CustomerType == CustomerType.Individual
    //                    orderby o.OrderId descending
    //                    orderby c.CompanyName ascending
    //                    select new CustomerOrderDetail()
    //                    {
    //                        OrderId = o.OrderId,
    //                        ProductId = p.ProductId,
    //                        ProductName = p.ProductName,
    //                        UnitPrice = od.UnitPrice,
    //                        Quantity = od.Quantity,
    //                        Discount = od.Discount,
    //                        CompanyName = c.CompanyName,
    //                        ContactName = c.ContactName,
    //                        Phone = c.Phone,
    //                        OrderDate = o.OrderDate,
    //                        RequiredDate = o.RequiredDate,
    //                        ShippedDate = o.ShippedDate
    //                    };
    //        try
    //        {
    //            List<CustomerOrderDetail> customerOrderDetails = testQuery.Top(1000).NoLock().ToList();
    //}
    //        catch (Exception ex)
    //        {
    //            throw;
    //        }

    //        return new string[] { "value1", "value2" };
    //}
}
