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
    // Products by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class ProductsByCategory : IEntity
    {
        public string CategoryName { get; set; } // CategoryName (Primary key) (length: 15)
        public string ProductName { get; set; } // ProductName (Primary key) (length: 40)
        public string QuantityPerUnit { get; set; } // QuantityPerUnit (length: 20)
        public short? UnitsInStock { get; set; } // UnitsInStock
        public bool Discontinued { get; set; } // Discontinued (Primary key)

//TODO: Deleted foreign key rows from here


        public ProductsByCategory()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
