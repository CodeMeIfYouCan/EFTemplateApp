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
    // The table 'Quarterly Orders' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Quarterly Orders
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class QuarterlyOrder : IEntity
    {
        public string CustomerId { get; set; } // CustomerID (length: 5)
        public string CompanyName { get; set; } // CompanyName (length: 40)
        public string City { get; set; } // City (length: 15)
        public string Country { get; set; } // Country (length: 15)

//TODO: Deleted foreign key rows from here


        public QuarterlyOrder()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
