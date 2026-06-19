using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2012 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };

            var expected = 2;

            var result = SumOfBeauties(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SumOfBeauties(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            var mx = nums[0];
            var mins = new int[n];
            mins[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                mins[i] = Math.Min(mins[i + 1], nums[i]);
            }
            for (int i = 1; i < n - 1; ++i)
            {
                if (nums[i] > mx && nums[i] < mins[i + 1])
                    result += 2;
                else if (nums[i] > nums[i - 1] && nums[i] < nums[i + 1])
                    result += 1;
                mx = Math.Max(mx, nums[i]);
            }
            return result;
        }
    }
}
