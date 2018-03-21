using EFTemplateCore.ServiceCommunicator;
using Modules.NorthWind.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClientApplication
{
    public class TestNorthWind
    {
        internal void TestNorthWindUnitOfWorkScope()
        {
            RestClient restClient = new RestClient("http://localhost:14547/api/");
            List<CustomerOrderDetailDto> test = restClient.Consume<List<CustomerOrderDetailDto>>("Test");
            Console.WriteLine("ProductName         UnitPrice   Quantity");
            foreach (var testRow in test)
            {
                Console.Write(EditCell(testRow.ProductName, 20));
                Console.Write(EditCell(testRow.UnitPrice.ToString(), 12));
                Console.Write(EditCell(testRow.Quantity.ToString(), 8));
                Console.WriteLine();
            }
        }

        string EditCell(string cellValue, int length)
        {
            string result = cellValue;
            if (string.IsNullOrEmpty(cellValue)) return result;
            if (cellValue.Length > length)
            {
                result = cellValue.Substring(0, length-3) + "...";
            }
            if (cellValue.Length < length)
            {
                for (int i = 0; i < length - cellValue.Length; i++)
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
