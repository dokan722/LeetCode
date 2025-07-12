using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // SAME AS 846
    public class _1296 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11 };
            var k = 3;

            var expected = true;

            var result = IsPossibleDivide(nums, k);

            return expected == result;
        }

        public bool IsPossibleDivide(int[] nums, int k)
        {
            var n = nums.Length;
            if (n % k != 0)
                return false;
            var freq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }
            var sorted = freq.Keys.ToArray();
            Array.Sort(sorted);

            foreach (int key in sorted)
            {
                int f = freq[key];
                if (f == 0) continue;

                for (int i = 0; i < k; i++)
                {
                    int next = key + i;
                    if (!freq.ContainsKey(next) || freq[next] < f)
                        return false;
                    freq[next] -= f;
                }
            }

            return true;
        }

        // slower for given data
        //public bool IsPossibleDivide(int[] nums, int k)
        //{
        //    var n = nums.Length;
        //    if (n % k != 0)
        //        return false;
        //    Array.Sort(nums);
        //    for (int i = 0; i < n / k; ++i)
        //    {
        //        int l = 0;
        //        while (nums[l] == -1)
        //            l++;
        //        var next = nums[l] + 1;
        //        nums[l] = -1;
        //        for (int j = 1; j < k; ++j)
        //        {
        //            while (nums[l] != next)
        //            {
        //                l++;
        //                if (l >= n)
        //                    return false;
        //            }

        //            next = nums[l] + 1;
        //            nums[l] = -1;
        //        }
        //    }

        //    return true;
        //}
    }
}
