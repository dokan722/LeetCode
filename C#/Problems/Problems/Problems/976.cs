using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _976 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 2 };

            var expected = 5;

            var result = LargestPerimeter(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int LargestPerimeter(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);

            for (int i = n - 1; i >= 2; --i)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                    return nums[i] + nums[i - 1] + nums[i - 2];
            }

            return 0;
        }
    }
}
