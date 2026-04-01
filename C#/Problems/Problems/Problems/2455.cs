using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2455 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 6, 10, 12, 15 };

            var expected = 9;

            var result = AverageValue(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AverageValue(int[] nums)
        {
            var s = 0;
            var n = 0;
            foreach (var num in nums)
            {
                if (num % 6 == 0)
                {
                    s += num;
                    n++;
                }
            }

            return n != 0 ? s / n : 0;
        }
    }
}
