

namespace Modules.Dms.DataLayer 
{
    using EFTemplateCore;
    using EFTemplateCore.Interfaces;
    using Modules.Dms.DataLayer.Domain;
    using Modules.Dms.DataLayer.Domain.Enums;
    using System.Data.Common;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
    // DocumentRepository

	//You can customize this class.
	public partial class DocumentRepository : GenericRepository<Document> , IDocumentRepository<Document>
	{
	}
}

