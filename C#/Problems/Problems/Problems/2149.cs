using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2149 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 1, -2, -5, 2, -4 };

            var expected = new[] { 3, -2, 1, -5, 2, -4 };

            var result = RearrangeArray(nums);

            return result.SequenceEqual(expected);

        }

        public int[] RearrangeArray(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            int neg = 1;
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < 0)
                {
                    result[neg] = nums[i];
                    neg += 2;
                }
                else
                {
                    result[pos] = nums[i];
                    pos += 2;
                }
            }

            return result;
        }
    }
}
