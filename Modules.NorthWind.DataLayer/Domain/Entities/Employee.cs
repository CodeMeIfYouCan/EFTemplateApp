
// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
#pragma warning disable 1591    //  Ignore 'Missing XML Comment' warning


namespace Modules.NorthWind.DataLayer 
{
    using EFTemplateCore;
    using EFTemplateCore.Interfaces;
    using Modules.NorthWind.DataLayer.Data;
    using Modules.NorthWind.DataLayer.Domain;
    using Modules.NorthWind.DataLayer.Domain.Enums;
    using System.Data.Common;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
    // Employees
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Employee : IEntity
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

//TODO: Deleted relational properties

//TODO: Deleted foreign key rows from here


        public Employee()
        {
//TODO: Deleted relational property creation rows.
            InitializePartial();
        }

        partial void InitializePartial();
    }

}


		// </auto-generated>