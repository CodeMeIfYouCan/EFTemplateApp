

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
    // Category Sales for 1997Repository

	//You can customize this class.
	public partial class CategorySalesFor1997Repository : GenericRepository<CategorySalesFor1997> , ICategorySalesFor1997Repository<CategorySalesFor1997>
	{
	}
}

