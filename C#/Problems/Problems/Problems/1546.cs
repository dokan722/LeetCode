using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1546 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1, 1, 1 };
            var target = 2;

            var expected = 2;

            var result = MaxNonOverlapping(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxNonOverlapping(int[] nums, int target)
        {
            var present = new HashSet<int>();
            present.Add(0);
            var cur = 0;
            var result = 0;
            foreach (var num in nums)
            {
                cur += num;
                var req = cur - target;
                if (present.Contains(req))
                {
                    result++;
                    present.Clear();
                    cur = 0;
                }
                present.Add(cur);
            }

            return result;
        }
    }
}
