using EFTemplateCore.ServiceCommunicator;
using Modules.NorthWind.ViewModels;
using Modules.NorthWind.ViewModels.DataTransferObjects;
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
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            userInfo.Add("Username", "1");
            userInfo.Add("Password", "2");
            List<CustomerOrderDetailDto> customerOrder = new List<CustomerOrderDetailDto>();
            try {
                customerOrder = restClient.Consume<CustomerOrderDetailResponse>("CustomerOrder/GetCustomerOrderDetail", "POST", customerOrderDetailRequest, userInfo).CustomerOrderDetails;
            }
            catch (Exception ex) {
            }
            Console.WriteLine("ProductName         UnitPrice   Quantity");
            if (customerOrder != null)
                foreach (var testRow in customerOrder) {
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
                EmployeeDto = new EmployeeDto() {
                    EmployeeId = 0,
                    LastName = "Engin",
                    FirstName = "Türenç",
                    Title = "Türenç Engin",
                    TitleOfCourtesy = "TE",
                    BirthDate = new DateTime(1986, 07, 14),
                    HireDate = new DateTime(2018, 01, 15),
                    Address = "Sanayi Mahallesi, Teknopark Bulvarı 1/3C Kurtköy - Pendik",
                    City = "İstanbul",
                    Region = "Anadolu",
                    PostalCode = "34906",
                    Country = "Türkiye",
                    HomePhone = "+90 216 664 20 00",
                    Extension = "",
                    Photo = null,
                    Notes = "Developer",
                    ReportsTo = null,
                    PhotoPath = ""
                }
            };

            EmployeeResponse employeeResponse = restClient.Consume<EmployeeResponse>("Employee/InsertEmpoloyee", employeeRequest); ;
            Console.WriteLine($"EmployeeId: {employeeResponse.EmployeeId}");
        }


        string EditCell(string cellValue, int length)
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
