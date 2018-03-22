using EFTemplateCore.TransactionManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.NorthWind.ViewModels.Response
{
    public class CustomerOrderDetailResponse : BaseResponseMessage
    {
        public List<CustomerOrderDetailDto> CustomerOrderDetails { get; set; }
    }
}
