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
    // Current Product List
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public  class CurrentProductListConfiguration : IEntityTypeConfiguration<CurrentProductList>
    {
    public void Configure(EntityTypeBuilder<CurrentProductList> builder)
        {
            builder.ToTable("Current Product List", "dbo");
            builder.HasKey(x => new { x.ProductId, x.ProductName });

            builder.Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ProductName).HasColumnType("nvarchar(40)").IsRequired().HasMaxLength(40).ValueGeneratedNever();



//TODO: Deleted foreign key and relation mapping configuration rows from here


        }
    }
  
}
// </auto-generated>