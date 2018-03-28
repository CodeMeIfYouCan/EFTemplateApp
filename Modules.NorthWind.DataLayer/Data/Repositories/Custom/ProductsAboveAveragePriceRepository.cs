

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
    // Products Above Average PriceRepository

	//You can customize this class.
	public partial class ProductsAboveAveragePriceRepository : GenericRepository<ProductsAboveAveragePrice> , IProductsAboveAveragePriceRepository<ProductsAboveAveragePrice>
	{
	}
}

