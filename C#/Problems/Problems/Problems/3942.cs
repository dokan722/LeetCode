using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3942 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 2, 1 };

            var expected = 2;

            var result = MinOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
                return 0;
            var zero = 0;
            for (int i = 1; i < n; ++i)
            {
                var diff = Math.Abs(nums[i] - nums[i - 1]);
                if (diff != 1 && diff != n - 1)
                    return -1;
                if (nums[i] == 0)
                    zero = i;
            }
            if (nums[(zero + 1) % n] - nums[zero] == 1)
            {
                return Math.Min(zero, n - 1 - zero + 3);
            }
            return Math.Min(n - 1 - zero + 1, zero + 2);
        }
    }
}
