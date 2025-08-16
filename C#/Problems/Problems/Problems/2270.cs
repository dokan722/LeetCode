using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2270 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 4, -8, 7 };

            var expected = 2;

            var result = WaysToSplitArray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int WaysToSplitArray(int[] nums)
        {
            long sumRight = 0;
            foreach (var num in nums)
                sumRight += num;
            long sumLeft = 0;
            var result = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                sumRight -= nums[i];
                sumLeft += nums[i];
                if (sumLeft >= sumRight)
                    result++;
            }

            return result;
        }
    }
}
