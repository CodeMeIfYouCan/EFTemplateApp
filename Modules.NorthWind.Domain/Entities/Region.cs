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
    using Modules.NorthWind.Domain.Enums;
	using Microsoft.EntityFrameworkCore;
    // Region
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Region : IEntity
    {
        public int RegionId { get; set; } // RegionID (Primary key)
        public string RegionDescription { get; set; } // RegionDescription (length: 50)

//TODO: Deleted relational properties

//TODO: Deleted foreign key rows from here


        public Region()
        {
//TODO: Deleted relational property creation rows.
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>