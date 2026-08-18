using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3471 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 9, 2, 1, 7 };
            var k = 3;

            var expected = 7;

            var result = LargestInteger(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LargestInteger(int[] nums, int k)
        {
            var n = nums.Length;
            var counts = new int[51];
            foreach (var num in nums)
                counts[num]++;
            if (k == 1)
            {
                for (int i = 50; i >= 0; --i)
                    if (counts[i] == 1)
                        return i;
            }
            else if (k == n)
            {
                for (int i = 50; i >= 0; --i)
                    if (counts[i] != 0)
                        return i;
            }
            else
            {
                for (int i = 50; i >= 0; --i)
                    if (counts[i] == 1 && (i == nums[0] || i == nums[n - 1]))
                        return i;
            }
            return -1;
        }
    }
}
