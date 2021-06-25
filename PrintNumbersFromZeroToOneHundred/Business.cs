using System;
using System.Configuration;

namespace PrintNumbersFromZeroToOneHundred
{
    public class Business : IBusiness
    {
        public bool IsMultipleOf(int numberToRequest, int multipleOfNumber)
        {
            if (numberToRequest % multipleOfNumber == 0)
                return true;
            return false;
        }

        public void PrintResults(int numberToRequest, bool multipleOfThree, bool multipleOfFive)
        {
            if (multipleOfThree)
                if (multipleOfFive)
                    Console.WriteLine(ConfigurationManager.AppSettings.Get("multiple_of_three_and_five_string"));
                else
                    Console.WriteLine(ConfigurationManager.AppSettings.Get("multiple_of_three_string"));
            else if (multipleOfFive)
                Console.WriteLine(ConfigurationManager.AppSettings.Get("multiple_of_five_string"));
            else
                Console.WriteLine(numberToRequest);
        } 
    }
}

