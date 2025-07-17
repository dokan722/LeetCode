using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3202 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 4, 2, 3, 1, 4 };
            var k = 3;

            var expected = 4;

            var result = MaximumLength(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumLength(int[] nums, int k)
        {
            var lengths = new int[k, k];

            for (int i = 0; i < nums.Length; i++)
            {
                var mod = nums[i] % k;
                for (int j = 0; j < k; ++j)
                    lengths[mod, j] = lengths[j, mod] + 1;
            }

            var result = int.MinValue;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; ++j)
                {
                    if (lengths[i, j] > result)
                        result = lengths[i, j];
                }
            }

            return result;
        }
    }
}
