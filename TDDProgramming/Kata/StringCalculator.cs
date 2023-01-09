﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProgramming.Kata
{
    public class StringCalculator
    {        
        private char[] delimeters = { ',', '\n'};
        private const string SEPERATELINE = "//";
        private static List<string> negativeNumberList = new();   
        private static bool negativeNumberFound = false;      
        public int Add(string input)
        {
            int sumOfNumbers = 0;
            if (string.IsNullOrEmpty(input))
            {
                return sumOfNumbers;
            }                      
           
            if (input.StartsWith(SEPERATELINE) && input.Length > 1)
            {
                var splitString = input.Split();
                UpdateDelimeter(splitString[0]);
                input = splitString[1];                
            }
            var splitInputStringWithDelimeter = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            sumOfNumbers = GetSumOfNumbers(splitInputStringWithDelimeter);
            if (negativeNumberList.Count > 0)
            {
                var negativeValues = String.Join(',', negativeNumberList);
                throw new ArgumentException($"negatives not allowed: {negativeValues}");
            }
            return sumOfNumbers;
        }

        
        private void UpdateDelimeter(string splitString)
        {
            foreach (var character in splitString)
            {
                if (character != '/')
                {
                    delimeters.SetValue(character, 0);
                }
            }
        }

        private static int GetSumOfNumbers(string[] splitInputString)
        {
            int sum = 0;
            foreach (var number in splitInputString)
            {
                int parsedNumber = int.Parse(number);
                if (parsedNumber > 0)
                {
                    sum += parsedNumber;
                }
                else
                {
                    negativeNumberList.Add(parsedNumber.ToString());
                }
                               
            }
            return sum;
            
        }
    }
}
