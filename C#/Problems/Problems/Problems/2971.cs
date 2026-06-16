using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2971 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 5, 5 };

            var expected = 15;

            var result = LargestPerimeter(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public long LargestPerimeter(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            long result = -1;
            long pref = nums[0] + nums[1];
            for (int i = 2; i < n; ++i)
            {
                if (nums[i] < pref)
                    result = nums[i] + pref;
                pref += nums[i];
            }
            return result;
        }
    }
}
