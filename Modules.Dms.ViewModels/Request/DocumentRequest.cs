

using EFTemplateCore.TransactionManager;
using Modules.Dms.ViewModels.DataTransferObjects;

namespace Modules.Dms.ViewModels.Request
{
    public class DocumentRequest : BaseRequestMessage
    {
        public DocumentDto DocumentDto { get; set; }

    }
}
