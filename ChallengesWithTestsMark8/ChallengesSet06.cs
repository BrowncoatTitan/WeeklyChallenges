using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            if (ignoreCase)
            {
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Any(w => w == word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if  (num <= 1) return false;
            return Enumerable.Range(2, num - 2).All(n => num % n != 0);
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var uniques = str.Where(x => str.Count(y => y == x) <= 1);
            if (uniques.Count() == 0) return -1;
            return str.IndexOf(uniques.Last());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Input array is empty or null.");
            }
            int maxCount = numbers.Length > 0 ? 1 : 0;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < n) return new double[] { };
            return elements.Where(element => elements.IndexOf(element) % n == n - 1).ToArray();
        }
    }
}
