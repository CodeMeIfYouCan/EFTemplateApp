
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
    // CustomerDemographics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial  class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographic>
    {
    public void Configure(EntityTypeBuilder<CustomerDemographic> builder)
        {
            builder.ToTable("CustomerDemographics", "dbo");
            builder.HasKey(x => x.CustomerTypeId);

            builder.Property(x => x.CustomerTypeId).HasColumnType("nchar(10)").IsRequired().HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.CustomerDesc).HasColumnName(@"CustomerDesc").HasColumnType("ntext").HasMaxLength(1073741823);



//TODO: Deleted foreign key and relation mapping configuration rows from here


            InitializePartial();
        }
        partial void InitializePartial();
    }
  
}


		// </auto-generated>