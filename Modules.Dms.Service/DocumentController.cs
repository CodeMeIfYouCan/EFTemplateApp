using System;
using System.Collections.Generic;
using System.Text;
using EFTemplateCore.ServiceCommunicator.Security;
using EFTemplateCore.TransactionManager;
using Microsoft.AspNetCore.Mvc;
using Modules.Dms.BusinessLogic.Queries;
using Modules.Dms.BusinessLogic.Transactions;
using Modules.Dms.DataLayer;
using Modules.Dms.ViewModels.Request;
using Modules.Dms.ViewModels.Response;

namespace Modules.Dms.Service
{
    [Route("api/[controller]")]
    public class DocumentController :Controller
    {

        readonly DocumentOperations documentOperations;
        readonly DocumentTransactions documentTransactions;
        readonly IDmsTransactionalUnitOfWork unitOfWork;
        readonly ICredentialValidator credentialValidator;
        public DocumentController(IDmsTransactionalUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            documentOperations = new DocumentOperations(unitOfWork);
            documentTransactions = new DocumentTransactions(unitOfWork);
            this.credentialValidator = CredentialValidationFactory.CreateDefaultInstance();
        }

        [HttpGet("[action]")]
        public IActionResult GetDocumentById(long id, [FromHeader] object obj)
        {
            //try {
            //    credentialValidator.CheckCredentials(this.Request.Headers);
            //}
            //catch (Exception ex) {
            //    Services.Create<ILog>().LogFormat("Unauthorized request.Exception:{0}", LogLevel.Warning, ex);
            //    return Unauthorized();
            //}

            DocumentResponse response = documentOperations.GetDocument(id);
            if (response == null)
                return NotFound();
            return new JsonResult(response);
        }


        [HttpPost("[action]")]
        public IActionResult InsertDocument([FromBody] DocumentRequest request)
        {
            DocumentResponse response = TransactionProcessor<DmsContext>.Execute
               (
                   documentTransactions.InsertDocument,
                   request,
                   unitOfWork
               );
            return new JsonResult(response);
        }
    }
}
