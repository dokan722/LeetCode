using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1413 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -3, 2, -3, 4, 2 };

            var expected = 5;

            var result = MinStartValue(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinStartValue(int[] nums)
        {
            var minPoint = int.MaxValue;
            var s = 0;
            foreach (var num in nums)
            {
                s += num;
                minPoint = Math.Min(s, minPoint);
            }

            return minPoint > 0 ? 1 : Math.Abs(minPoint) + 1;
        }
    }
}
