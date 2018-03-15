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
    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class NorthWindContext : EFContext, INorthWindContext
    {
        public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        public DbSet<Category> Categories { get; set; } // Categories
        public DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        public DbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        public DbSet<Customer> Customers { get; set; } // Customers
        public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        public DbSet<Employee> Employees { get; set; } // Employees
        public DbSet<Invoice> Invoices { get; set; } // Invoices
        public DbSet<Order> Orders { get; set; } // Orders
        public DbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        public DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        public DbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        public DbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        public DbSet<Product> Products { get; set; } // Products
        public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        public DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        public DbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        public DbSet<Region> Regions { get; set; } // Region
        public DbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        public DbSet<Shipper> Shippers { get; set; } // Shippers
        public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        public DbSet<Supplier> Suppliers { get; set; } // Suppliers
        public DbSet<Territory> Territories { get; set; } // Territories

        public NorthWindContext()
        {
            InitializePartial();
        }
		string connectionString = "";
        public NorthWindContext(string connectionString)
        {
            InitializePartial();
		    this.connectionString = connectionString;
        }


       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               if (!string.IsNullOrWhiteSpace(connectionString))
               {
                   optionsBuilder.UseSqlServer(connectionString);
               }
           }
       }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
		    modelBuilder.ApplyConfiguration<AlphabeticalListOfProduct>(new AlphabeticalListOfProductConfiguration());
		    modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
		    modelBuilder.ApplyConfiguration<CategorySalesFor1997>(new CategorySalesFor1997Configuration());
		    modelBuilder.ApplyConfiguration<CurrentProductList>(new CurrentProductListConfiguration());
		    modelBuilder.ApplyConfiguration<Customer>(new CustomerConfiguration());
		    modelBuilder.ApplyConfiguration<CustomerAndSuppliersByCity>(new CustomerAndSuppliersByCityConfiguration());
		    modelBuilder.ApplyConfiguration<CustomerDemographic>(new CustomerDemographicConfiguration());
		    modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
		    modelBuilder.ApplyConfiguration<Invoice>(new InvoiceConfiguration());
		    modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
		    modelBuilder.ApplyConfiguration<OrderDetail>(new OrderDetailConfiguration());
		    modelBuilder.ApplyConfiguration<OrderDetailsExtended>(new OrderDetailsExtendedConfiguration());
		    modelBuilder.ApplyConfiguration<OrdersQry>(new OrdersQryConfiguration());
		    modelBuilder.ApplyConfiguration<OrderSubtotal>(new OrderSubtotalConfiguration());
		    modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
		    modelBuilder.ApplyConfiguration<ProductsAboveAveragePrice>(new ProductsAboveAveragePriceConfiguration());
		    modelBuilder.ApplyConfiguration<ProductSalesFor1997>(new ProductSalesFor1997Configuration());
		    modelBuilder.ApplyConfiguration<ProductsByCategory>(new ProductsByCategoryConfiguration());
		    modelBuilder.ApplyConfiguration<Region>(new RegionConfiguration());
		    modelBuilder.ApplyConfiguration<SalesByCategory>(new SalesByCategoryConfiguration());
		    modelBuilder.ApplyConfiguration<SalesTotalsByAmount>(new SalesTotalsByAmountConfiguration());
		    modelBuilder.ApplyConfiguration<Shipper>(new ShipperConfiguration());
		    modelBuilder.ApplyConfiguration<SummaryOfSalesByQuarter>(new SummaryOfSalesByQuarterConfiguration());
		    modelBuilder.ApplyConfiguration<SummaryOfSalesByYear>(new SummaryOfSalesByYearConfiguration());
		    modelBuilder.ApplyConfiguration<Supplier>(new SupplierConfiguration());
		    modelBuilder.ApplyConfiguration<Territory>(new TerritoryConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
// </auto-generated>