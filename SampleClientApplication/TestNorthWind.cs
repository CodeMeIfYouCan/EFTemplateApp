using EFTemplateCore.ServiceCommunicator;
using Modules.NorthWind.ViewModels;
using Modules.NorthWind.ViewModels.Request;
using Modules.NorthWind.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClientApplication
{
    public class TestNorthWind
    {
        internal void GetCustomerOrderDetialsTest()
        {
            CustomerOrderDetailRequest customerOrderDetailRequest = new CustomerOrderDetailRequest();
            customerOrderDetailRequest.CustomerId = 24325;

            RestClient restClient = new RestClient("http://localhost:14547/api/");
            List<CustomerOrderDetailDto> customerOrder = restClient.Consume<CustomerOrderDetailResponse>("CustomerOrder", customerOrderDetailRequest).CustomerOrderDetails;
            Console.WriteLine("ProductName         UnitPrice   Quantity");
            foreach (var testRow in customerOrder)
            {
                Console.Write(EditCell(testRow.ProductName, 20));
                Console.Write(EditCell(testRow.UnitPrice.ToString(), 12));
                Console.Write(EditCell(testRow.Quantity.ToString(), 8));
                Console.WriteLine();
            }
        }
        
        internal void InsertEmployeeTest()
        {
            RestClient restClient = new RestClient("http://localhost:14547/api/");

            EmployeeRequest employeeRequest = new EmployeeRequest() { 
                EmployeeDto = new Modules.NorthWind.ViewModels.Model.EmployeeDto() {
                    FirstName = "Türenç",
                    LastName = "Engin"
                }
            };

            EmployeeResponse employeeResponse = restClient.Consume<EmployeeResponse>("Employee", employeeRequest); ;
            Console.WriteLine($"EmployeeId: {employeeResponse.EmployeeId}");
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
