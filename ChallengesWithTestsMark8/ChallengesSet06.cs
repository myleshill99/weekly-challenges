using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Count() == 0)
            {
                return false;
            }

            foreach (var w in words)
            {
                if (w != null && (w == word ||  (ignoreCase && w.ToLower() == word.ToLower())))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0 || num == 1 || num < 0)
            {
                return false;
            }

            for (var i = 2; i < num; i++)
            {
                if (num % i  == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            var isUnique = false;
            for (var i = 0; i < str.Length; i++)
            {
                isUnique = true;
                for (var j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var maxCount = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                } 
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count() == 0)
            {
                return new double[0];
            }

            if (n < 0)
            {
                return new double[0];
            }

            var result = new List<double>();

            for (var i = n - 1; i < elements.Count(); i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
