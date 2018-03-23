using EFTemplateCore.ServiceLocator;
using System;

namespace SampleClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultServices.RegisterDefaultServices();
            Console.WriteLine("Ef Template Service Tester");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Q)\t Select CustomerOrders");
            Console.WriteLine("I)\t Insert Employee");
            Console.WriteLine("E)\t Exit");
            Console.Write("Select option >>");

            string command = Console.ReadLine();
            while (command.ToUpper() != "E")
            {
                Console.WriteLine("");
                try
                {
                    HandleOptions(command);
                }
                catch (Exception ex)
                {
                    ex = ex.GetBaseException();

                    string errorMessage = "ExceptionMessage: " + ex.Message;
                    string stackTrace = ex.StackTrace;
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("StackTrace: {0}", stackTrace);
                }
                if (command.ToUpper() != "L")
                    Console.WriteLine("Select option >>");
                command = Console.ReadLine();
            }
        }
        static void HandleOptions(string command)
        {
            TestNorthWind testNorthWind = new TestNorthWind();
            switch (command.ToUpper())
            {
                case "Q":
                    testNorthWind.GetCustomerOrderDetialsTest();
                    break;
                case "I":
                    testNorthWind.InsertEmployeeTest();
                break;
                default:
                    break;
            }
        }
    }
}
