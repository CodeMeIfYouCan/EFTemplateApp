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
    // Order Details Extended
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public  class OrderDetailsExtendedConfiguration : IEntityTypeConfiguration<OrderDetailsExtended>
    {
    public void Configure(EntityTypeBuilder<OrderDetailsExtended> builder)
        {
            builder.ToTable("Order Details Extended", "dbo");
            builder.HasKey(x => new { x.OrderId, x.ProductId, x.ProductName, x.UnitPrice, x.Quantity, x.Discount });

            builder.Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ProductName).HasColumnType("nvarchar(40)").IsRequired().HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.UnitPrice).HasColumnType("decimal(19,4)").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("smallint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Discount).HasColumnName(@"Discount").HasColumnType("real").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ExtendedPrice).HasColumnType("decimal(19,4)");



//TODO: Deleted foreign key and relation mapping configuration rows from here


        }
    }
  
}
// </auto-generated>