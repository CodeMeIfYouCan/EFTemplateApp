
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
    // Orders Qry
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class OrdersQry : IEntity
    {
        public int OrderId { get; set; } // OrderID (Primary key)
        public string CustomerId { get; set; } // CustomerID (length: 5)
        public int? EmployeeId { get; set; } // EmployeeID
        public System.DateTime? OrderDate { get; set; } // OrderDate
        public System.DateTime? RequiredDate { get; set; } // RequiredDate
        public System.DateTime? ShippedDate { get; set; } // ShippedDate
        public int? ShipVia { get; set; } // ShipVia
        public decimal? Freight { get; set; } // Freight
        public string ShipName { get; set; } // ShipName (length: 40)
        public string ShipAddress { get; set; } // ShipAddress (length: 60)
        public string ShipCity { get; set; } // ShipCity (length: 15)
        public string ShipRegion { get; set; } // ShipRegion (length: 15)
        public string ShipPostalCode { get; set; } // ShipPostalCode (length: 10)
        public string ShipCountry { get; set; } // ShipCountry (length: 15)
        public string CompanyName { get; set; } // CompanyName (Primary key) (length: 40)
        public string Address { get; set; } // Address (length: 60)
        public string City { get; set; } // City (length: 15)
        public string Region { get; set; } // Region (length: 15)
        public string PostalCode { get; set; } // PostalCode (length: 10)
        public string Country { get; set; } // Country (length: 15)

//TODO: Deleted relational properties

//TODO: Deleted foreign key rows from here


        public OrdersQry()
        {
//TODO: Deleted relational property creation rows.
            InitializePartial();
        }

        partial void InitializePartial();
    }

}


		// </auto-generated>