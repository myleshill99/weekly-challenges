using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                } 
                else
                {
                    result -= number;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var length = objs.Length;
            var majority = length / 2 + 1;

            var numberOfNulls = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    numberOfNulls++;
                }
            }

            return numberOfNulls >= majority;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            var result = 1;
            for (var i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        } 
    }
}
