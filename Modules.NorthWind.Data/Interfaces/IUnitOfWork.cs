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
    // IUnitOfWork
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public interface IUnitOfWork  : System.IDisposable //TODO:   IBaseUnitOfWork can be added for access base unit of work 
    {
AlphabeticalListOfProductRepository AlphabeticalListOfProductRepository { get; }
CategoryRepository CategoryRepository { get; }
CategorySalesFor1997Repository CategorySalesFor1997Repository { get; }
CurrentProductListRepository CurrentProductListRepository { get; }
CustomerRepository CustomerRepository { get; }
CustomerAndSuppliersByCityRepository CustomerAndSuppliersByCityRepository { get; }
CustomerDemographicRepository CustomerDemographicRepository { get; }
EmployeeRepository EmployeeRepository { get; }
InvoiceRepository InvoiceRepository { get; }
OrderRepository OrderRepository { get; }
OrderDetailRepository OrderDetailRepository { get; }
OrderDetailsExtendedRepository OrderDetailsExtendedRepository { get; }
OrdersQryRepository OrdersQryRepository { get; }
OrderSubtotalRepository OrderSubtotalRepository { get; }
ProductRepository ProductRepository { get; }
ProductsAboveAveragePriceRepository ProductsAboveAveragePriceRepository { get; }
ProductSalesFor1997Repository ProductSalesFor1997Repository { get; }
ProductsByCategoryRepository ProductsByCategoryRepository { get; }
QuarterlyOrderRepository QuarterlyOrderRepository { get; }
RegionRepository RegionRepository { get; }
SalesByCategoryRepository SalesByCategoryRepository { get; }
SalesTotalsByAmountRepository SalesTotalsByAmountRepository { get; }
ShipperRepository ShipperRepository { get; }
SummaryOfSalesByQuarterRepository SummaryOfSalesByQuarterRepository { get; }
SummaryOfSalesByYearRepository SummaryOfSalesByYearRepository { get; }
SupplierRepository SupplierRepository { get; }
TerritoryRepository TerritoryRepository { get; }
}
}
// </auto-generated>