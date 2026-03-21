using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3737 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 2, 3 };
            var target = 2;

            var expected = 5;

            var result = CountMajoritySubarrays(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountMajoritySubarrays(int[] nums, int target)
        {
            var n = nums.Length;
            var counts = new int[2 * n + 2];
            var pref = new int[2 * n + 2];
            var cur = n + 1;
            pref[cur] = 1;
            counts[cur] = 1;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                cur += (nums[i] == target ? 1 : -1);
                counts[cur]++;
                pref[cur] = pref[cur - 1] + counts[cur];
                result += pref[cur - 1];
            }

            return result;
        }
    }
}
