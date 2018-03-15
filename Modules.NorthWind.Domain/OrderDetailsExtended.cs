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
    // Order Details Extended
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class OrderDetailsExtended : IEntity
    {
        public int OrderId { get; set; } // OrderID (Primary key)
        public int ProductId { get; set; } // ProductID (Primary key)
        public string ProductName { get; set; } // ProductName (Primary key) (length: 40)
        public decimal UnitPrice { get; set; } // UnitPrice (Primary key)
        public short Quantity { get; set; } // Quantity (Primary key)
        public float Discount { get; set; } // Discount (Primary key)
        public decimal? ExtendedPrice { get; set; } // ExtendedPrice

//TODO: Deleted foreign key rows from here


        public OrderDetailsExtended()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
