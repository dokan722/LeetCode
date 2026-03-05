using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2195 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 25, 10, 25 };
            var k = 2;

            var expected = 5;

            var result = MinimalKSum(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MinimalKSum(int[] nums, int k)
        {
            var n = nums.Length;
            long currSum = (long)k * (k + 1) / 2;
            Array.Sort(nums);
            var th = k;
            var prev = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] > th)
                    break;
                else if (nums[i] != prev)
                {
                    th++;
                    currSum += th - nums[i];
                    prev = nums[i];
                }
            }

            return currSum;
        }
    }
}
