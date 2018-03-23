using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace EFTemplateCore.ServiceCommunicator.Security
{
    public class DefaultCredentialProvider : ICredentialValidator
    {
        public void CheckCredentials(IHeaderDictionary headerInfo)
        {
            if (headerInfo != null) {
                if (headerInfo.ContainsKey(Constants.DefaultUserNameKey)) {
                    if (headerInfo[Constants.DefaultUserNameKey] != "1") {
                        throw new Exception(string.Format("UserName is not correct!,User Name:{0}", headerInfo[Constants.DefaultUserNameKey]));
                    }
                }
                if (headerInfo.ContainsKey(Constants.DefaultPasswordKey)) {
                    if (headerInfo[Constants.DefaultPasswordKey] != "1") {
                        throw new Exception(string.Format("UserName is not correct!,User Name:{0}", headerInfo[Constants.DefaultPasswordKey]));
                    }
                }
            }
        }
    }
}
