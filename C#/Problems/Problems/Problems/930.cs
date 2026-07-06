using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _930 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 1, 0, 1 };
            var goal = 2;

            var expected = 4;

            var result = NumSubarraysWithSum(nums, goal);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            var counts = new Dictionary<int, int>();
            var cur = 0;
            var result = 0;
            foreach (var num in nums)
            {
                if (counts.ContainsKey(cur))
                    counts[cur]++;
                else
                    counts[cur] = 1;
                cur += num;
                var req = cur - goal;
                if (counts.ContainsKey(req))
                    result += counts[req];
            }

            return result;
        }
    }
}
