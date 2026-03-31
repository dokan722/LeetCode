using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2644 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 9, 15, 50 };
            var divisors = new[] { 5, 3, 7, 2 };

            var expected = 2;

            var result = MaxDivScore(nums, divisors);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDivScore(int[] nums, int[] divisors)
        {
            var n = nums.Length;
            var m = divisors.Length;
            var result = divisors[0];
            var best = 0;
            for (int i = 0; i < m; ++i)
            {
                var cur = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (nums[j] % divisors[i] == 0)
                        cur++;
                }
                if (cur > best || (cur == best && divisors[i] < result))
                {
                    best = cur;
                    result = divisors[i];
                }
            }

            return result;
        }
    }
}
