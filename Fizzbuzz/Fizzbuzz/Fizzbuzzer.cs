using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Fizzbuzzer : IFizzbuzzer
    {
        public string getFizzbuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }

        public string PrintFizzbuzzSequence(int number)
        {
            string result = "";
            for(int i = 1; i <= number; i++)
            {
                result += getFizzbuzz(i) + " ";
            }

            Console.WriteLine(result);
            return result;
        }
    }
}