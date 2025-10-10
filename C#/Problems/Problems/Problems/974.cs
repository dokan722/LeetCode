using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _974 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 5, 0, -2, -3, 1 };
            var k = 5;

            var expected = 7;

            var result = SubarraysDivByK(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SubarraysDivByK(int[] nums, int k)
        {
            var n = nums.Length;
            var mods = new int[k];
            mods[0] = 1;
            var sum = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += nums[i];
                var mod = (sum % k + k) % k;
                result += mods[mod];
                mods[mod]++;
            }

            return result;
        }
    }
}
