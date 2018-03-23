using EFTemplateCore.ServiceCommunicator;
using Modules.Dms.ViewModels.DataTransferObjects;
using Modules.Dms.ViewModels.Request;
using Modules.Dms.ViewModels.Response;
using System;
using System.Collections.Generic;

namespace IntegrationTests
{
    public static class TestDocuments
    {
        public static void GetDocument()
        {
            RestClient restClient = new RestClient("http://localhost:14547/api/");
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            userInfo.Add("Username", "1");
            userInfo.Add("Password", "2");
            DocumentDto doc = null;
            try {
                doc = restClient.Consume<DocumentResponse>("Document/GetDocumentById", "GET", 1, userInfo).Document;
            }
            catch (Exception ex) {
            }
            Console.WriteLine("ProductName         UnitPrice   Quantity");
            if (doc != null) {
                Console.Write(EditCell(doc.Id.ToString(), 20));
                Console.Write(EditCell(doc.CreateDate.ToString(), 12));
                Console.Write(EditCell(doc.Name, 8));
                Console.WriteLine();
            }
        }
        public static void InsertDocument()
        {
            RestClient restClient = new RestClient("http://localhost:14547/api/");

            DocumentRequest documentRequest = new DocumentRequest() {
                DocumentDto = new DocumentDto() {
                    Name = "emrah",
                    Path = "123123",
                    CreateDate = DateTime.Now,
                    UserName = "Username"
                }
            };

            DocumentResponse documentResponse = restClient.Consume<DocumentResponse>("Document/InsertDocument", documentRequest);
            Console.WriteLine($"EmployeeId: {documentResponse.Document.Id}");
        }
        static string EditCell(string cellValue, int length)
        {
            string result = cellValue;
            if (string.IsNullOrEmpty(cellValue)) return result;
            if (cellValue.Length > length) {
                result = cellValue.Substring(0, length - 3) + "...";
            }
            if (cellValue.Length < length) {
                for (int i = 0; i < length - cellValue.Length; i++) {
                    result += " ";
                }
            }
            return result;
        }
    }
}
