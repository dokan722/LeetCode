using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly165
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -34 };

            var expected = 3;

            var result = SmallestAbsent(nums);
            
            Console.WriteLine(result);
            
            return expected == result;
        }

        public int SmallestAbsent(int[] nums)
        {
            var n = nums.Length;
            var present = new bool[101];
            var sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] > 0)
                    present[nums[i]] = true;
                sum += nums[i];
            }

            var ceil = Math.Max(1, (sum + n) / n);
            for (int i = ceil; i < 101; ++i)
                if (!present[i])
                    return i;
            return 101;
        }
    }
}
