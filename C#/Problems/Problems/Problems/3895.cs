using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3895 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 12, 54, 32, 22 };
            var digit = 2;

            var expected = 4;

            var result = CountDigitOccurrences(nums, digit);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountDigitOccurrences(int[] nums, int digit)
        {
            var result = 0;
            foreach (var num in nums)
            {
                var cur = num;
                while (cur > 0)
                {
                    if (cur % 10 == digit)
                        result++;
                    cur /= 10;
                }
            }

            return result;
        }
    }
}
