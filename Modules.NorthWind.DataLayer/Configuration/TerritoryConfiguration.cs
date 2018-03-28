
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
    // Territories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial  class TerritoryConfiguration : IEntityTypeConfiguration<Territory>
    {
    public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.ToTable("Territories", "dbo");
            builder.HasKey(x => x.TerritoryId);

            builder.Property(x => x.TerritoryId).HasColumnType("nvarchar(20)").IsRequired().HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.TerritoryDescription).HasColumnType("nchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.RegionId).HasColumnName(@"RegionID").HasColumnType("int").IsRequired();



//TODO: Deleted foreign key and relation mapping configuration rows from here


            InitializePartial();
        }
        partial void InitializePartial();
    }
  
}


		// </auto-generated>