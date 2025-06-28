using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2099 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 2, 1, 3, 3 };
            var k = 2;

            var expected = new int[] { 3, 3 };

            var result = MaxSubsequence(nums, k);

            Console.WriteLine(string.Join(",", result));

            return result.SequenceEqual(expected);
        }

        public int[] MaxSubsequence(int[] nums, int k)
        {
            var indexed = new int[nums.Length][];
            for (int i = 0; i < nums.Length; i++)
                indexed[i] = new int[] { i, nums[i] };
            Array.Sort(indexed, (x, y) => y[1].CompareTo(x[1]));
            var result = indexed.Take(k).OrderBy(x => x[0]).Select(x => x[1]).ToArray();
            return result;
        }

    }
}
