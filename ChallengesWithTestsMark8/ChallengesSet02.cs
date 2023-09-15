using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
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
            if (number % 2 == 0) { return true; } return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) { return true; } return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null || numbers.Count() <= 0) return 0;
            var max =numbers?.Max(x => x);
            var min =numbers?.Min(x => x); return max + min ?? 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
           return numbers?.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            var sumEvens = numbers?.Where(x => x % 2 == 0).Sum();
            return sumEvens ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false; 
            
           var isOdd = numbers?.Sum();
            if (isOdd % 2 != 0) 
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
           for (var n = 1; n < number; n += 2)
            {
                count++;
            }
           return count;
        }
    }
}
