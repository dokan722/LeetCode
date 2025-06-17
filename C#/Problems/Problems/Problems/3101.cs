using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3101 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 0, 1, 1, 1 };

            var expected = 5;

            var result = CountAlternatingSubarrays(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountAlternatingSubarrays(int[] nums)
        {
            var prev = nums[0];
            nums[0] = 1;
            long result = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != prev)
                {
                    prev = nums[i];
                    nums[i] = nums[i - 1] + 1;
                }
                else
                {
                    prev = nums[i];
                    nums[i] = 1;
                }

                result += nums[i];
            }

            return result;
        }
    }
}
