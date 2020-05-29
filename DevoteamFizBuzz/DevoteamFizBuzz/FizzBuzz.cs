using System;
using System.Collections.Generic;
using System.Text;

namespace DevoteamFizBuzz
{
    public class FizzBuzz
    {
        public string GetTextFromNumber(int number)
        {
            if (number == 3)
                return "Fizz";
            return number.ToString();
        } 
        
    }
}
