using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2200 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 9, 1, 3, 9, 5 };

            var key = 9;
            var k = 1;

            var expected = new[] { 1, 2, 3, 4, 5, 6 };

            var result = FindKDistantIndices(nums, key, k);

            return expected.SequenceEqual(result);
        }

        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            var right = 0;
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {
                    var left = Math.Max(right, i - k);
                    right = Math.Min(nums.Length, i + k + 1);
                    for (int j = left; j < right; j++)
                        result.Add(j);
                }
            }

            return result;
        }
    }
}
