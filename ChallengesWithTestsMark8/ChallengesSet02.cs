using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i].ToString().ToLower() == c.ToString().ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length; 
            } 
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }

           return result;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var result = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }

            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 == 0)
            {
                return false; 
            }
            else
            {
                return true; 
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var positiveOddNumberCount = 0;
            for (int i = 0; i < number; i++)
            {
                if (i > 0 && i % 2 != 0)
                {
                    positiveOddNumberCount++;
                }
            }

            return positiveOddNumberCount;
        }
    }
}
