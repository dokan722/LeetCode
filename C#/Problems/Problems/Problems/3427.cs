using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3427 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 1 };

            var expected = 11;

            var result = SubarraySum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SubarraySum(int[] nums)
        {
            var n = nums.Length;
            var pref = new int[n + 1];
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                pref[i + 1] = nums[i] + pref[i];
                var start = Math.Max(0, i - nums[i]);
                result += pref[i + 1] - pref[start];
            }

            return result;
        }
    }
}
