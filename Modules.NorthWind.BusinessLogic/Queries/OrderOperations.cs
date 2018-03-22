using EFTemplateCore.Extensions;
using Modules.NorthWind.Data;
using Modules.NorthWind.ViewModels;
using Modules.NorthWind.ViewModels.DataTransferObjects;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;
using System.Collections.Generic;
using System.Linq;
namespace Modules.NorthWind.BusinessLogic.Transactions
{
    public class OrderOperations
    {
        readonly INorthWindUnitOfWork northWindUnitOfWork;
        public OrderOperations(INorthWindUnitOfWork northWindUnitOfWork)
        {
            this.northWindUnitOfWork = northWindUnitOfWork;
        }
        public CustomerOrderDetailResponse GetCustomerOrderDetails(CustomerOrderDetailRequest request)
        {
            List<CustomerOrderDetailDto> customerOrderDetails = new List<CustomerOrderDetailDto>();
            CustomerRepository customers = northWindUnitOfWork.CustomerRepository;
            OrderRepository orders = northWindUnitOfWork.OrderRepository;
            OrderDetailRepository orderDetails = northWindUnitOfWork.OrderDetailRepository;
            ProductRepository products = northWindUnitOfWork.ProductRepository;

            var testQuery = from c in customers.AsQueryable()
                            join o in orders.Table() on c.CustomerId equals o.CustomerId
                            join od in orderDetails.Table() on o.OrderId equals od.OrderId
                            join p in products.Table() on od.ProductId equals p.ProductId
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

            customerOrderDetails = testQuery.Top(1).NoLock().ToList();
            return new CustomerOrderDetailResponse() { CustomerOrderDetails = customerOrderDetails } ;
        }
    }
}
