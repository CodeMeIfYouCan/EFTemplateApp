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
// TargetFrameworkVersion = 2
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Modules.NorthWind.Domain
{
    using  EFTemplateCore.Interfaces;
    using Modules.NorthWind.Domain.Enums;
	using Microsoft.EntityFrameworkCore;
    // Orders
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Order : IEntity
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

//TODO: Deleted relational properties

//TODO: Deleted foreign key rows from here


        public Order()
        {
            Freight = 0m;
//TODO: Deleted relational property creation rows.
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>