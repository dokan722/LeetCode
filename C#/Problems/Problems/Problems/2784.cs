using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2784 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 3 };

            var expected = false;

            var result = IsGood(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool IsGood(int[] nums)
        {
            var n = nums.Length;
            var present = new bool[201];
            var count = 0;
            foreach (var num in nums)
            {
                if (present[num] && num != n - 1 || num > n - 1)
                    return false;
                present[num] = true;
                if (num != n - 1)
                    count++;
            }

            return count == n - 2 && present[n - 1];
        }
    }
}
