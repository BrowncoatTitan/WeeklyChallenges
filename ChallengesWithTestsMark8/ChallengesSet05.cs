using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(startNumber + 1, startNumber + n)
                   .First(x => x % n == 0);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            var noRev = businesses.Where(r => r.TotalRevenue == 0);
            foreach (var r in noRev)
            {
                r.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Select((num, index) => index > 0 && 
                   numbers[index - 1] % 2 == 0 ? num : 0).Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0 || words.All(w => string.IsNullOrWhiteSpace(w)))
                return "";
            var words2 = words.Select(word => word.Replace(" ", ""));
            var words3 = words2.Where(w => !string.IsNullOrWhiteSpace(w));
            return string.Join(" ", words3) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null|| elements.Count < 4) return new double[] {};
           return elements.Where(element => elements.IndexOf(element) % 4 == 3).ToArray();
        }
    

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            return nums
           .SelectMany((x, i) => nums.Skip(i + 1).Select(y => (x, y)))
           .Any(pair => pair.x + pair.y == targetNumber);
        }
    }
}
