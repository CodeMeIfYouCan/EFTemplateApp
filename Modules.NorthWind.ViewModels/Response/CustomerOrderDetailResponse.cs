using EFTemplateCore.TransactionManager;
using Modules.NorthWind.ViewModels.DataTransferObjects;
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
