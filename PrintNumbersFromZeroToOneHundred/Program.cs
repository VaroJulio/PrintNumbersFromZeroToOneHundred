using System;
using System.Configuration;

namespace PrintNumbersFromZeroToOneHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("separator_string"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("start_string"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("separator_string"));
            Console.WriteLine();
            IBusiness business = new Business();
            for (int x = 0; x <= 100; x++)
            {
                bool multipleOfThree = business.IsMultipleOf(x, 3);
                bool multipleOfFive = business.IsMultipleOf(x, 5);
                business.PrintResults(x, multipleOfThree, multipleOfFive);
            }
            Console.Write(ConfigurationManager.AppSettings.Get("finish_string"));
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
