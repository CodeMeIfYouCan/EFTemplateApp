using EFTemplateCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.NorthWind.ViewModels.DataTransferObjects
{
    public class CustomerOrderDetailDto : IDto
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
