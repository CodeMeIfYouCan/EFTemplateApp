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
    using System.Data.Common;
using Microsoft.EntityFrameworkCore;
    // UnitOfWork
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public class UnitOfWork : BaseUnitOfWork<NorthWindContext>, IUnitOfWork
    {	    
		public UnitOfWork()
	    :base()
        {
        }

		 public UnitOfWork(string connectionString)
	    :base(connectionString)
        {
        }

	    public UnitOfWork(DbTransaction existingTransaction)
	    :base(existingTransaction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(DbConnection existingConnection)
		:base(existingConnection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(NorthWindContext context)
		:base(context)
        {
        }

		AlphabeticalListOfProductRepository _AlphabeticalListOfProductRepository;
		public AlphabeticalListOfProductRepository AlphabeticalListOfProductRepository
        {
            get
            {
                if (_AlphabeticalListOfProductRepository == null)
                {
                    _AlphabeticalListOfProductRepository  = new AlphabeticalListOfProductRepository(context);
                }
                return _AlphabeticalListOfProductRepository;
            }
        }

		CategoryRepository _CategoryRepository;
		public CategoryRepository CategoryRepository
        {
            get
            {
                if (_CategoryRepository == null)
                {
                    _CategoryRepository  = new CategoryRepository(context);
                }
                return _CategoryRepository;
            }
        }

		CategorySalesFor1997Repository _CategorySalesFor1997Repository;
		public CategorySalesFor1997Repository CategorySalesFor1997Repository
        {
            get
            {
                if (_CategorySalesFor1997Repository == null)
                {
                    _CategorySalesFor1997Repository  = new CategorySalesFor1997Repository(context);
                }
                return _CategorySalesFor1997Repository;
            }
        }

		CurrentProductListRepository _CurrentProductListRepository;
		public CurrentProductListRepository CurrentProductListRepository
        {
            get
            {
                if (_CurrentProductListRepository == null)
                {
                    _CurrentProductListRepository  = new CurrentProductListRepository(context);
                }
                return _CurrentProductListRepository;
            }
        }

		CustomerRepository _CustomerRepository;
		public CustomerRepository CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository  = new CustomerRepository(context);
                }
                return _CustomerRepository;
            }
        }

		CustomerAndSuppliersByCityRepository _CustomerAndSuppliersByCityRepository;
		public CustomerAndSuppliersByCityRepository CustomerAndSuppliersByCityRepository
        {
            get
            {
                if (_CustomerAndSuppliersByCityRepository == null)
                {
                    _CustomerAndSuppliersByCityRepository  = new CustomerAndSuppliersByCityRepository(context);
                }
                return _CustomerAndSuppliersByCityRepository;
            }
        }

		CustomerDemographicRepository _CustomerDemographicRepository;
		public CustomerDemographicRepository CustomerDemographicRepository
        {
            get
            {
                if (_CustomerDemographicRepository == null)
                {
                    _CustomerDemographicRepository  = new CustomerDemographicRepository(context);
                }
                return _CustomerDemographicRepository;
            }
        }

		EmployeeRepository _EmployeeRepository;
		public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_EmployeeRepository == null)
                {
                    _EmployeeRepository  = new EmployeeRepository(context);
                }
                return _EmployeeRepository;
            }
        }

		InvoiceRepository _InvoiceRepository;
		public InvoiceRepository InvoiceRepository
        {
            get
            {
                if (_InvoiceRepository == null)
                {
                    _InvoiceRepository  = new InvoiceRepository(context);
                }
                return _InvoiceRepository;
            }
        }

		OrderRepository _OrderRepository;
		public OrderRepository OrderRepository
        {
            get
            {
                if (_OrderRepository == null)
                {
                    _OrderRepository  = new OrderRepository(context);
                }
                return _OrderRepository;
            }
        }

		OrderDetailRepository _OrderDetailRepository;
		public OrderDetailRepository OrderDetailRepository
        {
            get
            {
                if (_OrderDetailRepository == null)
                {
                    _OrderDetailRepository  = new OrderDetailRepository(context);
                }
                return _OrderDetailRepository;
            }
        }

		OrderDetailsExtendedRepository _OrderDetailsExtendedRepository;
		public OrderDetailsExtendedRepository OrderDetailsExtendedRepository
        {
            get
            {
                if (_OrderDetailsExtendedRepository == null)
                {
                    _OrderDetailsExtendedRepository  = new OrderDetailsExtendedRepository(context);
                }
                return _OrderDetailsExtendedRepository;
            }
        }

		OrdersQryRepository _OrdersQryRepository;
		public OrdersQryRepository OrdersQryRepository
        {
            get
            {
                if (_OrdersQryRepository == null)
                {
                    _OrdersQryRepository  = new OrdersQryRepository(context);
                }
                return _OrdersQryRepository;
            }
        }

		OrderSubtotalRepository _OrderSubtotalRepository;
		public OrderSubtotalRepository OrderSubtotalRepository
        {
            get
            {
                if (_OrderSubtotalRepository == null)
                {
                    _OrderSubtotalRepository  = new OrderSubtotalRepository(context);
                }
                return _OrderSubtotalRepository;
            }
        }

		ProductRepository _ProductRepository;
		public ProductRepository ProductRepository
        {
            get
            {
                if (_ProductRepository == null)
                {
                    _ProductRepository  = new ProductRepository(context);
                }
                return _ProductRepository;
            }
        }

		ProductsAboveAveragePriceRepository _ProductsAboveAveragePriceRepository;
		public ProductsAboveAveragePriceRepository ProductsAboveAveragePriceRepository
        {
            get
            {
                if (_ProductsAboveAveragePriceRepository == null)
                {
                    _ProductsAboveAveragePriceRepository  = new ProductsAboveAveragePriceRepository(context);
                }
                return _ProductsAboveAveragePriceRepository;
            }
        }

		ProductSalesFor1997Repository _ProductSalesFor1997Repository;
		public ProductSalesFor1997Repository ProductSalesFor1997Repository
        {
            get
            {
                if (_ProductSalesFor1997Repository == null)
                {
                    _ProductSalesFor1997Repository  = new ProductSalesFor1997Repository(context);
                }
                return _ProductSalesFor1997Repository;
            }
        }

		ProductsByCategoryRepository _ProductsByCategoryRepository;
		public ProductsByCategoryRepository ProductsByCategoryRepository
        {
            get
            {
                if (_ProductsByCategoryRepository == null)
                {
                    _ProductsByCategoryRepository  = new ProductsByCategoryRepository(context);
                }
                return _ProductsByCategoryRepository;
            }
        }

		QuarterlyOrderRepository _QuarterlyOrderRepository;
		public QuarterlyOrderRepository QuarterlyOrderRepository
        {
            get
            {
                if (_QuarterlyOrderRepository == null)
                {
                    _QuarterlyOrderRepository  = new QuarterlyOrderRepository(context);
                }
                return _QuarterlyOrderRepository;
            }
        }

		RegionRepository _RegionRepository;
		public RegionRepository RegionRepository
        {
            get
            {
                if (_RegionRepository == null)
                {
                    _RegionRepository  = new RegionRepository(context);
                }
                return _RegionRepository;
            }
        }

		SalesByCategoryRepository _SalesByCategoryRepository;
		public SalesByCategoryRepository SalesByCategoryRepository
        {
            get
            {
                if (_SalesByCategoryRepository == null)
                {
                    _SalesByCategoryRepository  = new SalesByCategoryRepository(context);
                }
                return _SalesByCategoryRepository;
            }
        }

		SalesTotalsByAmountRepository _SalesTotalsByAmountRepository;
		public SalesTotalsByAmountRepository SalesTotalsByAmountRepository
        {
            get
            {
                if (_SalesTotalsByAmountRepository == null)
                {
                    _SalesTotalsByAmountRepository  = new SalesTotalsByAmountRepository(context);
                }
                return _SalesTotalsByAmountRepository;
            }
        }

		ShipperRepository _ShipperRepository;
		public ShipperRepository ShipperRepository
        {
            get
            {
                if (_ShipperRepository == null)
                {
                    _ShipperRepository  = new ShipperRepository(context);
                }
                return _ShipperRepository;
            }
        }

		SummaryOfSalesByQuarterRepository _SummaryOfSalesByQuarterRepository;
		public SummaryOfSalesByQuarterRepository SummaryOfSalesByQuarterRepository
        {
            get
            {
                if (_SummaryOfSalesByQuarterRepository == null)
                {
                    _SummaryOfSalesByQuarterRepository  = new SummaryOfSalesByQuarterRepository(context);
                }
                return _SummaryOfSalesByQuarterRepository;
            }
        }

		SummaryOfSalesByYearRepository _SummaryOfSalesByYearRepository;
		public SummaryOfSalesByYearRepository SummaryOfSalesByYearRepository
        {
            get
            {
                if (_SummaryOfSalesByYearRepository == null)
                {
                    _SummaryOfSalesByYearRepository  = new SummaryOfSalesByYearRepository(context);
                }
                return _SummaryOfSalesByYearRepository;
            }
        }

		SupplierRepository _SupplierRepository;
		public SupplierRepository SupplierRepository
        {
            get
            {
                if (_SupplierRepository == null)
                {
                    _SupplierRepository  = new SupplierRepository(context);
                }
                return _SupplierRepository;
            }
        }

		TerritoryRepository _TerritoryRepository;
		public TerritoryRepository TerritoryRepository
        {
            get
            {
                if (_TerritoryRepository == null)
                {
                    _TerritoryRepository  = new TerritoryRepository(context);
                }
                return _TerritoryRepository;
            }
        }

}
}
// </auto-generated>
