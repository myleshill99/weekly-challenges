using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                } 
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            
            var sum = 0;

            foreach (var val in numbers)
            {
                sum += val;
            }

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var containsUpper = false;
            var containsLower = false;
            var containsNumber = false;

            foreach (char character in password)
            {
                if (char.IsLower(character))
                {
                    containsLower = true;
                }
                else if (char.IsUpper(character))
                {
                    containsUpper = true;
                } 
                else if (char.IsNumber(character))
                {
                    containsNumber = true;
                }
            }

            return containsLower && containsUpper && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string is null or empty");
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string is null or empty");
            }

            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor; 
        }

        public int LastMinusFirst(int[] nums)
        {
            var firstItem = nums[0];
            var lastItem = nums[^1];

            return lastItem - firstItem;
        }

        public int[] GetOddsBelow100()
        {
            var result = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}



