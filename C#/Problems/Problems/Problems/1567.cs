using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1567 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -2, -3, 4 };

            var expected = 4;

            var result = GetMaxLen(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int GetMaxLen(int[] nums)
        {
            var n = nums.Length;
            var prev = -1;
            var first = -1;
            var last = -1;
            var count = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] < 0)
                {
                    count++;
                    last = i;
                    if (first == -1)
                        first = i;
                }
                else if (nums[i] == 0)
                {
                    if (count % 2 == 0)
                    {
                        result = Math.Max(result, i - prev - 1);
                    }
                    else
                    {
                        var best = Math.Max(i - first - 1, last - prev - 1);
                        result = Math.Max(result, best);
                    }
                    count = 0;
                    first = -1;
                    last = -1;
                    prev = i;
                }
            }
            if (count % 2 == 0)
            {
                result = Math.Max(result, n - prev - 1);
            }
            else
            {
                var best = Math.Max(n - first - 1, last - prev - 1);
                result = Math.Max(result, best);
            }


            return result;
        }
    }
}
