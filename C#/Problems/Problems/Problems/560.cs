using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _560 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1 };
            var k = 2;

            var expected = 2;

            var result = SubarraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SubarraySum(int[] nums, int k)
        {
            var prev = new Dictionary<int, int>();
            prev[0] = 1;
            var cur = 0;
            var result = 0;
            foreach (var num in nums)
            {
                cur += num;
                var req = cur - k;
                if (prev.ContainsKey(req))
                    result += prev[req];
                if (prev.ContainsKey(cur))
                    prev[cur]++;
                else
                    prev[cur] = 1;
            }

            return result;
        }
    }
}
