using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3862 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 2 };

            var expected = 1;

            var result = SmallestBalancedIndex(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestBalancedIndex(int[] nums)
        {
            long s = 0;
            foreach (var num in nums)
                s += num;
            long prod = 1;
            var i = nums.Length - 1;
            while (prod < s)
            {
                s -= nums[i];
                if (s == prod)
                    return i;
                if (prod > s / nums[i])
                    break;
                prod *= nums[i];
                --i;
            }

            return -1;
        }
    }
}
