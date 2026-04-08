using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3653 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1 };
            var queries = new[] { new[] { 0, 2, 1, 4 } };

            var expected = 4;

            var result = XorAfterQueries(nums, queries);

            Console.WriteLine(result);

            return result == expected;
        }

        public int XorAfterQueries(int[] nums, int[][] queries)
        {
            foreach (var query in queries)
            {
                for (int i = query[0]; i <= query[1]; i += query[2])
                {
                    long x = (long)nums[i] * query[3] % 1000000007;
                    nums[i] = (int)x;
                }
            }

            var result = nums[0];
            for (int i = 1; i < nums.Length; ++i)
                result ^= nums[i];

            return result;
        }
    }
}
