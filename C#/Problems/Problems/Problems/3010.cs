using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3010 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 3, 1, 1 };

            var expected = 12;

            var result = MinimumCost(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumCost(int[] nums)
        {
            var n = nums.Length;
            var m = Math.Min(nums[1], nums[2]);
            var sm = Math.Max(nums[1], nums[2]);
            for (int i = 3; i < n; ++i)
            {
                if (nums[i] < m)
                {
                    sm = m;
                    m = nums[i];
                }
                else if (nums[i] < sm)
                {
                    sm = nums[i];
                }
            }

            return nums[0] + m + sm;
        }
    }
}
