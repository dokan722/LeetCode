using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3411 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 1, 2, 1, 1, 1 };

            var expected = 5;

            var result = MaxLength(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxLength(int[] nums)
        {
            var n = nums.Length;
            var result = 2;
            var left = 0;
            var cur = 1;
            for (int i = 0; i < n; i++)
            {
                int x = nums[i];
                while (GCD(cur, x) > 1)
                    cur /= nums[left++];
                cur *= x;
                result = Math.Max(result, i - left + 1);
            }
            return result;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
