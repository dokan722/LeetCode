using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3917 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = new[] { 2, 1, 1, 0 };

            var result = CountOppositeParity(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] CountOppositeParity(int[] nums)
        {
            var n = nums.Length;
            var even = 0;
            var odd = 0;
            var result = new int[n];
            for (int i = n - 1; i >= 0; --i)
            {
                if (nums[i] % 2 == 0)
                {
                    result[i] = odd;
                    even++;
                }
                else
                {
                    result[i] = even;
                    odd++;
                }
            }

            return result;
        }
    }
}
