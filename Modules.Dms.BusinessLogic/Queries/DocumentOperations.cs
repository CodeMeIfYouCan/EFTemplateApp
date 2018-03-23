using EFTemplateCore.Extensions;
using Modules.Dms.DataLayer;
using Modules.Dms.ViewModels.DataTransferObjects;
using Modules.Dms.ViewModels.Request;
using Modules.Dms.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using EFTemplateCore.ModelMapper;

namespace Modules.Dms.BusinessLogic.Queries
{
    public class DocumentOperations
    {
        readonly IDmsUnitOfWork DmsUnitOfWork;
        public DocumentOperations(IDmsUnitOfWork DmsUnitOfWork)
        {
            this.DmsUnitOfWork = DmsUnitOfWork;
        }
        public DocumentResponse GetDocument(long id)
        {
            DocumentResponse response = new DocumentResponse();
            DocumentRepository documentRepository = DmsUnitOfWork.DocumentRepository;
            var query = documentRepository.GetDocumentByKey(id);
            response.Document = query.ToDto<Document, DocumentDto>();
            return response;
        }
    }
}
