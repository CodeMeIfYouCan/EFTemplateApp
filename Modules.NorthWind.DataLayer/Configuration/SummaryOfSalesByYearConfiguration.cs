
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
    // Summary of Sales by Year
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial  class SummaryOfSalesByYearConfiguration : IEntityTypeConfiguration<SummaryOfSalesByYear>
    {
    public void Configure(EntityTypeBuilder<SummaryOfSalesByYear> builder)
        {
            builder.ToTable("Summary of Sales by Year", "dbo");
            builder.HasKey(x => x.OrderId);

            builder.Property(x => x.ShippedDate).HasColumnName(@"ShippedDate").HasColumnType("datetime");
            builder.Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Subtotal).HasColumnType("decimal(19,4)");



//TODO: Deleted foreign key and relation mapping configuration rows from here


            InitializePartial();
        }
        partial void InitializePartial();
    }
  
}


		// </auto-generated>