using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1403 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 3, 10, 9, 8 };

            var expected = new[] { 10, 9 };

            var result = MinSubsequence(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> MinSubsequence(int[] nums)
        {
            var n = nums.Length;
            var result = new List<int>();
            Array.Sort(nums);
            var s = 0;
            foreach (var num in nums)
                s += num;
            var cur = 0;
            while (cur <= s - cur)
            {
                var next = nums[n - 1 - result.Count];
                result.Add(next);
                cur += next;
            }
            return result;
        }
    }
}
