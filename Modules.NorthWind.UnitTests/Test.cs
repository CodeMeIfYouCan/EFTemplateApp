using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            using (UnitOfWork unitOfWork = new UnitOfWork("server=S0134DBTEMP; user=quantra; password=quantra2; database=NorthWindDatabase; pooling=true; Max Pool Size=100; Min Pool Size=8"))
            {
                CustomerRepository customerRepository = unitOfWork.CustomerRepository;
                OrderRepository orderRepository = unitOfWork.OrderRepository;

                var testQuery = from c in customerRepository.All()
                                join o in orderRepository.All() on c.CustomerId equals o.CustomerId
                                select c;

                testQuery.Top(10).ToList();
            }
            Assert.IsTrue(1 == 1);
        }
    }
}
