using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.NorthWind.ViewModels.Model
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string LastName { get; set; } // LastName (length: 20)
        public string FirstName { get; set; } // FirstName (length: 10)
        public string Title { get; set; } // Title (length: 30)
        public string TitleOfCourtesy { get; set; } // TitleOfCourtesy (length: 25)
        public System.DateTime? BirthDate { get; set; } // BirthDate
        public System.DateTime? HireDate { get; set; } // HireDate
        public string Address { get; set; } // Address (length: 60)
        public string City { get; set; } // City (length: 15)
        public string Region { get; set; } // Region (length: 15)
        public string PostalCode { get; set; } // PostalCode (length: 10)
        public string Country { get; set; } // Country (length: 15)
        public string HomePhone { get; set; } // HomePhone (length: 24)
        public string Extension { get; set; } // Extension (length: 4)
        public byte[] Photo { get; set; } // Photo (length: 2147483647)
        public string Notes { get; set; } // Notes (length: 1073741823)
        public int? ReportsTo { get; set; } // ReportsTo
        public string PhotoPath { get; set; } // PhotoPath (length: 255)

    }
}
