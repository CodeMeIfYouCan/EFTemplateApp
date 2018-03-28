
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
    public interface INorthWindContext : System.IDisposable
    {
        DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        DbSet<Category> Categories { get; set; } // Categories
        DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        DbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        DbSet<Customer> Customers { get; set; } // Customers
        DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        DbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        DbSet<Employee> Employees { get; set; } // Employees
        DbSet<Invoice> Invoices { get; set; } // Invoices
        DbSet<Order> Orders { get; set; } // Orders
        DbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        DbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        DbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        DbSet<Product> Products { get; set; } // Products
        DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        DbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        DbSet<Region> Regions { get; set; } // Region
        DbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        DbSet<Shipper> Shippers { get; set; } // Shippers
        DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        DbSet<Supplier> Suppliers { get; set; } // Suppliers
        DbSet<Territory> Territories { get; set; } // Territories

        int SaveChanges();

        Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker ChangeTracker { get; }
        Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade Database { get; }
        Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Entry(object entity);
        Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

    }

}


		// </auto-generated>