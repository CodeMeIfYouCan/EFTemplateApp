using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.ServiceCommunicator.Security
{
    public interface ICredentialValidator
    {
        void CheckCredentials(IHeaderDictionary headerInfo);
    }
}
