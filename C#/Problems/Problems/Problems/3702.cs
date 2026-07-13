using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3702 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };

            var expected = 2;

            var result = LongestSubsequence(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestSubsequence(int[] nums)
        {
            var n = nums.Length;
            var xor = 0;
            var nonZero = false;
            foreach (var num in nums)
            {
                xor ^= num;
                if (num != 0)
                    nonZero = true;
            }
            if (xor != 0)
                return n;
            if (nonZero)
                return n - 1;
            return 0;
        }
    }
}
