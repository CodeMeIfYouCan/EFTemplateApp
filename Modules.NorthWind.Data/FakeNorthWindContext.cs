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
    using Modules.NorthWind.Data.Interfaces;
    using Modules.NorthWind.Domain;
    using Modules.NorthWind.Interfaces;
    using System.Data.Common;
	using Microsoft.EntityFrameworkCore;
    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class FakeNorthWindContext : INorthWindContext
    {
        public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; }
        public DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public DbSet<OrdersQry> OrdersQries { get; set; }
        public DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        public DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<SalesByCategory> SalesByCategories { get; set; }
        public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }

        public FakeNorthWindContext()
        {
            AlphabeticalListOfProducts = new FakeDbSet<AlphabeticalListOfProduct>("ProductId", "ProductName", "Discontinued", "CategoryName");
            Categories = new FakeDbSet<Category>("CategoryId");
            CategorySalesFor1997 = new FakeDbSet<CategorySalesFor1997>("CategoryName");
            CurrentProductLists = new FakeDbSet<CurrentProductList>("ProductId", "ProductName");
            Customers = new FakeDbSet<Customer>("CustomerId");
            CustomerAndSuppliersByCities = new FakeDbSet<CustomerAndSuppliersByCity>("CompanyName", "Relationship");
            CustomerDemographics = new FakeDbSet<CustomerDemographic>("CustomerTypeId");
            Employees = new FakeDbSet<Employee>("EmployeeId");
            Invoices = new FakeDbSet<Invoice>("CustomerName", "Salesperson", "OrderId", "ShipperName", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            Orders = new FakeDbSet<Order>("OrderId");
            OrderDetails = new FakeDbSet<OrderDetail>("OrderId", "ProductId");
            OrderDetailsExtendeds = new FakeDbSet<OrderDetailsExtended>("OrderId", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            OrdersQries = new FakeDbSet<OrdersQry>("OrderId", "CompanyName");
            OrderSubtotals = new FakeDbSet<OrderSubtotal>("OrderId");
            Products = new FakeDbSet<Product>("ProductId");
            ProductsAboveAveragePrices = new FakeDbSet<ProductsAboveAveragePrice>("ProductName");
            ProductSalesFor1997 = new FakeDbSet<ProductSalesFor1997>("CategoryName", "ProductName");
            ProductsByCategories = new FakeDbSet<ProductsByCategory>("CategoryName", "ProductName", "Discontinued");
            Regions = new FakeDbSet<Region>("RegionId");
            SalesByCategories = new FakeDbSet<SalesByCategory>("CategoryId", "CategoryName", "ProductName");
            SalesTotalsByAmounts = new FakeDbSet<SalesTotalsByAmount>("OrderId", "CompanyName");
            Shippers = new FakeDbSet<Shipper>("ShipperId");
            SummaryOfSalesByQuarters = new FakeDbSet<SummaryOfSalesByQuarter>("OrderId");
            SummaryOfSalesByYears = new FakeDbSet<SummaryOfSalesByYear>("OrderId");
            Suppliers = new FakeDbSet<Supplier>("SupplierId");
            Territories = new FakeDbSet<Territory>("TerritoryId");

            InitializePartial();
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker _changeTracker;
        public Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker ChangeTracker { get { return _changeTracker; } }
        
        private Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade _database;
        public Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade Database { get { return _database; } }
        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
// </auto-generated>
