

using EFTemplateCore.Interfaces;

namespace Modules.Dms.ViewModels.DataTransferObjects
{
    public class DocumentDto:IDto
    {
        public long Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 200)
        public string Path { get; set; } // Path (length: 250)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UserName { get; set; } // UserName (length: 50)
    }
}
