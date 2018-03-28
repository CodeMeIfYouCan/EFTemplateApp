

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
    // Product Sales for 1997Repository

	//You can customize this class.
	public partial class ProductSalesFor1997Repository : GenericRepository<ProductSalesFor1997> , IProductSalesFor1997Repository<ProductSalesFor1997>
	{
	}
}

