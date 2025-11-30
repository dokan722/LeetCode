using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1590 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };
            var p = 7;

            var expected = -1;

            var result = MinSubarray(nums, p);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSubarray(int[] nums, int p)
        {
            var n = nums.Length;
            var rest = 0;
            for (int i = 0; i < n; ++i)
            {
                rest = (rest + nums[i]) % p;
            }

            if (rest == 0)
                return 0;

            var prev = new Dictionary<int, int>();
            prev[0] = -1;
            var result = int.MaxValue;
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                curr = (curr + nums[i]) % p;
                var req = (curr - rest + p) % p;
                if (prev.ContainsKey(req))
                    result = Math.Min(result, i - prev[req]);
                prev[curr] = i;
            }

            return result >= n ? -1 : result;
        }
    }
}
