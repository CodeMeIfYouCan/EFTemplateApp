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
using Microsoft.EntityFrameworkCore;
    // Customers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Customer : IEntity
    {
        public string CustomerId { get; set; } // CustomerID (Primary key) (length: 5)
        public string CompanyName { get; set; } // CompanyName (length: 40)
        public string ContactName { get; set; } // ContactName (length: 30)
        public string ContactTitle { get; set; } // ContactTitle (length: 30)
        public string Address { get; set; } // Address (length: 60)
        public string City { get; set; } // City (length: 15)
        public string Region { get; set; } // Region (length: 15)
        public string PostalCode { get; set; } // PostalCode (length: 10)
        public string Country { get; set; } // Country (length: 15)
        public string Phone { get; set; } // Phone (length: 24)
        public string Fax { get; set; } // Fax (length: 24)

        // Reverse navigation

        /// <summary>
        /// Child CustomerDemographics (Many-to-Many) mapped by table [CustomerCustomerDemo]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CustomerDemographic> CustomerDemographics { get; set; } // Many to many mapping
        /// <summary>
        /// Child Orders where [Orders].[CustomerID] point to this entity (FK_Orders_Customers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Customers

//TODO: Deleted foreign key rows from here


        public Customer()
        {
            Orders = new System.Collections.Generic.List<Order>();
            CustomerDemographics = new System.Collections.Generic.List<CustomerDemographic>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>