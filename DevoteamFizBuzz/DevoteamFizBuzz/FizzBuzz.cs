using System;
using System.Collections.Generic;
using System.Text;

namespace DevoteamFizzBuzz
{
    public class FizzBuzz
    {
        public string GetTextFromNumber(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            if (number % 3 == 0)
                return "Fizz";
            return number.ToString();
        } 

        
    }
}
