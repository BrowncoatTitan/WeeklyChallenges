using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = numbers.Where(x => x % 2 == 0).Sum();
            var odds = numbers.Where(x => x % 2 != 0).Sum();
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strArray = new string[] { str1, str2, str3, str4 };
            return strArray.Min(l =>  l.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var intArray = new int[] { number1, number2, number3, number4 };
            return intArray.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 < sideLength2 + sideLength3 && 
                   sideLength2 < sideLength3 + sideLength1 && 
                   sideLength3 < sideLength1 + sideLength2; 
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullNum = objs.Where(i => i == null).Count();
            return nullNum > objs.Length/2;
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = numbers?.Where(x => x%2 == 0);
            if (evens == null || evens.Count() <= 0 ) return 0;
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            return Enumerable.Range(1, number).Aggregate((accumulator,next) => accumulator*next);
        }
    }
}
