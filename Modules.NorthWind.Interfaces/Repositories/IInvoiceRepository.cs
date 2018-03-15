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


namespace Modules.NorthWind.Interfaces
{
    using EFTemplateCore.Interfaces;
    using Modules.NorthWind.Domain;
using Microsoft.EntityFrameworkCore;
    // InvoicesRepository
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
public interface IInvoiceRepository<Invoice> : IRepository<Invoice> where Invoice : class, IEntity, new()
{
    Invoice GetInvoiceByKey(string CustomerName, string Salesperson, int OrderId, string ShipperName, int ProductId, string ProductName, decimal UnitPrice, short Quantity, float Discount);
}
}
// </auto-generated>
