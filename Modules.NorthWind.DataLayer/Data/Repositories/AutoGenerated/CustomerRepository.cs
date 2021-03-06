
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
    // CustomersRepository
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
public partial class CustomerRepository : GenericRepository<Customer> , ICustomerRepository<Customer>
{
    public CustomerRepository(EFContext context, string safeCode)
        : base(context, safeCode)
    {
    }
    public CustomerRepository(EFContext context)
        : base(context)
    {
    }
	    public Customer GetCustomerByKey(string CustomerId)
    {
        return FirstOrDefault(p => p.CustomerId==CustomerId);
    }
	}
}


		// </auto-generated>