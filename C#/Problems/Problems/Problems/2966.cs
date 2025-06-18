using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2966 :IProblem
    {
        public bool Test()
        {
            var nums = new [] {1, 3, 4, 8, 7, 9, 3, 5, 1};

            var k = 2;

            var expected = new[] { new int[]  { 1, 1, 3 }, new int[]  { 3, 4, 5 }, new int[] { 7, 8, 9 } };

            var result = DivideArray(nums, k);

            if (result.Length != expected.Length)
                return false;

            foreach (var arr in expected)
            {
                if (!result.Any(x => x.SequenceEqual(arr)))
                    return false;
            }

            return true;
        }

        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var results = new int[nums.Length /3][];

            for (var i = 0; i < nums.Length; i += 3)
            {
                if (Math.Abs(nums[i] - nums[i + 2]) > k)
                    return Array.Empty<int[]>();
                results[i / 3] = new int[3] { nums[i], nums[i + 1], nums[i + 2] };
            }

            return results;
        }
    }
}
