using Microsoft.EntityFrameworkCore.ChangeTracking;
using Modules.Dms.DataLayer;
using Modules.Dms.ViewModels.DataTransferObjects;
using Modules.Dms.ViewModels.Request;
using Modules.Dms.ViewModels.Response;
using EFTemplateCore.ModelMapper;

namespace Modules.Dms.BusinessLogic.Transactions
{
    public class DocumentTransactions
    {
        readonly IDmsUnitOfWork dmsUnitOfWork;
        public DocumentTransactions(IDmsUnitOfWork dmsUnitOfWork)
        {
            this.dmsUnitOfWork = dmsUnitOfWork;
        }
        public DocumentResponse InsertDocument(DocumentRequest request)
        {
            DocumentResponse response = new DocumentResponse();
            DocumentDto documentDto = request.DocumentDto;
            DocumentRepository documentRepository = dmsUnitOfWork.DocumentRepository;
            EntityEntry<Document> document = documentRepository.Add(documentDto.ToEntity<DocumentDto, Document>());
            response.Document = document.Entity.ToDto<Document, DocumentDto>();
            return response;
        }
    }
}
