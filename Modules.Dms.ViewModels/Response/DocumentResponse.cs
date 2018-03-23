using EFTemplateCore.TransactionManager;
using Modules.Dms.ViewModels.DataTransferObjects;
using System.Collections.Generic;

namespace Modules.Dms.ViewModels.Response
{
    public class DocumentResponse: BaseResponseMessage
    {
        public DocumentDto Document { get; set; }
    }
}
