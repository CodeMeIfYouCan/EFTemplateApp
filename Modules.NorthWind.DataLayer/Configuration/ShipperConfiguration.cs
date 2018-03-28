
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
    // Shippers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial  class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
    public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers", "dbo");
            builder.HasKey(x => x.ShipperId);

            builder.Property(x => x.ShipperId).HasColumnName(@"ShipperID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CompanyName).HasColumnType("nvarchar(40)").IsRequired().HasMaxLength(40);
            builder.Property(x => x.Phone).HasColumnType("nvarchar(24)").HasMaxLength(24);



//TODO: Deleted foreign key and relation mapping configuration rows from here


            InitializePartial();
        }
        partial void InitializePartial();
    }
  
}


		// </auto-generated>