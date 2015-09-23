using System;

namespace CSharp.Training
{
    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz Compute Method
        /// * If the number is divisible by three then the result will be "Fizz"
        /// * If the number is divisible by five then the result will be "Buzz"
        /// * If the number is divisible by three and five then the result will be "FizzBuzz"
        /// </summary>
        /// <param name="number">Number to compute</param>
        /// <returns>Computed result</returns>
        public string module(int number)
        {
            string result = "";
            if (number % 3 == 0)
            {
                result = "Fizz";
                if (number % 5 == 0)
                {
                    result += "Buzz";
                }
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = "Nope";
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
