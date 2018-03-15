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
    // Customer and Suppliers by City
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public  class CustomerAndSuppliersByCityConfiguration : IEntityTypeConfiguration<CustomerAndSuppliersByCity>
    {
    public void Configure(EntityTypeBuilder<CustomerAndSuppliersByCity> builder)
        {
            builder.ToTable("Customer and Suppliers by City", "dbo");
            builder.HasKey(x => new { x.CompanyName, x.Relationship });

            builder.Property(x => x.City).HasColumnType("nvarchar(15)").HasMaxLength(15);
            builder.Property(x => x.CompanyName).HasColumnType("nvarchar(40)").IsRequired().HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.ContactName).HasColumnType("nvarchar(30)").HasMaxLength(30);
            builder.Property(x => x.Relationship).HasColumnType("varchar(9)").IsRequired().IsUnicode(false).HasMaxLength(9).ValueGeneratedNever();



//TODO: Deleted foreign key and relation mapping configuration rows from here


        }
    }
  
}
// </auto-generated>
