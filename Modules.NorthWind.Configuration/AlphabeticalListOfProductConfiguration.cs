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


namespace Modules.NorthWind.Configuration
{
    using Modules.NorthWind.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
    // Alphabetical list of products
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public  class AlphabeticalListOfProductConfiguration : IEntityTypeConfiguration<AlphabeticalListOfProduct>
    {
    public void Configure(EntityTypeBuilder<AlphabeticalListOfProduct> builder)
        {
            builder.ToTable("Alphabetical list of products", "dbo");
            builder.HasKey(x => new { x.ProductId, x.ProductName, x.Discontinued, x.CategoryName });

            builder.Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ProductName).HasColumnType("nvarchar(40)").IsRequired().HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("int");
            builder.Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("int");
            builder.Property(x => x.QuantityPerUnit).HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.UnitPrice).HasColumnType("decimal(19,4)");
            builder.Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint");
            builder.Property(x => x.UnitsOnOrder).HasColumnName(@"UnitsOnOrder").HasColumnType("smallint");
            builder.Property(x => x.ReorderLevel).HasColumnName(@"ReorderLevel").HasColumnType("smallint");
            builder.Property(x => x.Discontinued).HasColumnName(@"Discontinued").HasColumnType("bit").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CategoryName).HasColumnType("nvarchar(15)").IsRequired().HasMaxLength(15).ValueGeneratedNever();



//TODO: Deleted foreign key and relation mapping configuration rows from here


        }
    }
  
}
// </auto-generated>
