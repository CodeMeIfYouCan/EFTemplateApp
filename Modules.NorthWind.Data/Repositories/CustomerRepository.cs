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


namespace Modules.NorthWind.Data
{
    using EFTemplateCore;
    using Modules.NorthWind.Configuration;
    using Modules.NorthWind.Domain;
    using Modules.NorthWind.Interfaces;
using Microsoft.EntityFrameworkCore;
    // CustomersRepository
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
//This class is created once by the code generator. If file exists, it will not be overwritten by the code generator. So you can customize this class
public class CustomerRepository : GenericRepository<Customer> , ICustomerRepository<Customer>
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
