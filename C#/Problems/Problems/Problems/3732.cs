using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3732 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -5, 7, 0 };

            long expected = 3500000;

            var result = MaxProduct(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxProduct(int[] nums)
        {
            var n = nums.Length;
            var mins = new int[2] { int.MaxValue, int.MaxValue };
            var maxs = new int[2] { int.MinValue, int.MinValue };
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] > maxs[0])
                {
                    maxs[1] = maxs[0];
                    maxs[0] = nums[i];
                }
                else if (nums[i] > maxs[1])
                    maxs[1] = nums[i];
                if (nums[i] < mins[0])
                {
                    mins[1] = mins[0];
                    mins[0] = nums[i];
                }
                else if (nums[i] < mins[1])
                    mins[1] = nums[i];
            }
            var best = Math.Max(Math.Max(Math.Abs((long)mins[0] * mins[1]), Math.Abs((long)maxs[0] * maxs[1])), Math.Abs((long)maxs[0] * mins[0]));

            return best * 100000;
        }
    }
}
