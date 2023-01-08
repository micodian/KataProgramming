using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProgramming.Kata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            int sumOfNumbers = 0;
            if (string.IsNullOrEmpty(input))
            {
                return sumOfNumbers;
            }
            var splitInputString = input.Split(',', '\n');
            sumOfNumbers = GetSumOfNumbers(splitInputString);
            return sumOfNumbers;
        }

        private static int GetSumOfNumbers(string[] splitInputString)
        {
            int sum = 0;
            foreach (var number in splitInputString)
            {
                sum += int.Parse(number);
            }
            return sum;
            
        }
    }
}
