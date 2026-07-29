using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1673 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 5, 2, 6 };
            var k = 2;

            var expected = new[] { 2, 6 };

            var result = MostCompetitive(nums, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MostCompetitive(int[] nums, int k)
        {
            var n = nums.Length;
            if (n == k)
                return nums;
            var result = new int[k];
            var id = 0;
            for (int i = 0; i < n; ++i)
            {
                var cur = nums[i];
                var left = n - i - 1;
                while (left >= k - id && id > 0 && result[id - 1] > cur)
                    id--;
                if (id < k)
                    result[id++] = cur;
            }
            return result;
        }
    }
}
