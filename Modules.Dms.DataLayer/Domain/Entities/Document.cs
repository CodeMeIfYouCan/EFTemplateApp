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


namespace Modules.Dms.DataLayer
{
    using EFTemplateCore;
    using EFTemplateCore.Interfaces;
    using Modules.Dms.DataLayer.Data;
    using Modules.Dms.DataLayer.Data.Interfaces;
    using Modules.Dms.DataLayer.Domain;
    using Modules.Dms.DataLayer.Domain.Enums;
    using System.Data.Common;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
    // Document
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Document : IEntity
    {
        public long Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 200)
        public string Path { get; set; } // Path (length: 250)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UserName { get; set; } // UserName (length: 50)

//TODO: Deleted relational properties

//TODO: Deleted foreign key rows from here


        public Document()
        {
            CreateDate = System.DateTime.Now;
//TODO: Deleted relational property creation rows.
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
