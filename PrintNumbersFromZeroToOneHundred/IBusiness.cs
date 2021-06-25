using System;
using System.Collections.Generic;
using System.Text;

namespace PrintNumbersFromZeroToOneHundred
{
    public interface IBusiness
    {
        public bool IsMultipleOf(int numberToRequest, int multipleOfNumber);
        public void PrintResults(int numberToRequestbool, bool multipleOfThree, bool multipleOfFive);
    }
}
