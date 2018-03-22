using EFTemplateCore.TransactionManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.NorthWind.ViewModels.Request
{
    public class CustomerOrderDetailRequest : BaseRequestMessage
    {
        public long CustomerId { get; set; }
    }
}
