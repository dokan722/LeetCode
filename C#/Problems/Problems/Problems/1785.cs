using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1785 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -1, 1 };
            var limit = 3;
            var goal = -4;

            var expected = 2;

            var result = MinElements(nums, limit, goal);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinElements(int[] nums, int limit, int goal)
        {
            long s = 0;
            foreach (var num in nums)
                s += num;
            return (int)((Math.Abs(goal - s) + Math.Abs(limit) - 1) / limit);
        }
    }
}
