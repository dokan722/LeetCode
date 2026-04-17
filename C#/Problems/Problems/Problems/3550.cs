using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3550 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2 };

            var expected = 2;

            var result = SmallestIndex(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int SmallestIndex(int[] nums)
        {
            var n = nums.Length;
            for (int i = 0; i < n; ++i)
            {
                var num = nums[i];
                var s = 0;
                while (num > 0)
                {
                    s += num % 10;
                    num /= 10;
                }
                if (s == i)
                    return s;
            }

            return -1;
        }
    }
}
