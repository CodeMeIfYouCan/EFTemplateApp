using System;

namespace SampleClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ef Template Service Tester");
            Console.WriteLine("-------------------------");
            Console.WriteLine("N)\t Test NorthWind UnitOfWork Scope");
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
                case "N":
                    testNorthWind.TestNorthWindUnitOfWorkScope();
                    break;
                default:
                    break;
            }
        }
    }
}
