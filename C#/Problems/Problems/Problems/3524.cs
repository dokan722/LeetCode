using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3524 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };
            var k = 3;

            var expected = new long[] { 9, 2, 4 };

            var result = ResultArray(nums, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public long[] ResultArray(int[] nums, int k)
        {
            var result = new long[k];
            var prev = new long[k];
            foreach (var num in nums)
            {
                var rem = num % k;
                var next = new long[k];
                for (int i = 0; i < k; ++i)
                {
                    next[(i * rem) % k] += prev[i];
                }
                next[rem]++;
                for (int i = 0; i < k; ++i)
                {
                    result[i] += next[i];
                }
                prev = next;
            }

            return result;
        }
    }
}
