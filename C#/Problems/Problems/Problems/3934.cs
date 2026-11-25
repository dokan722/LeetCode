using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3934 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 3, 3 };

            var expected = 3;

            var result = SmallestUniqueSubarray(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int SmallestUniqueSubarray(int[] nums)
        {
            var n = nums.Length;
            long mod = 1000000007;
            long b = 964277491;

            var preH = new long[n + 1];
            var preP = new long[n + 1];
            preP[0] = 1;
            for (int i = 0; i < n; ++i)
            {
                preH[i + 1] = (preH[i] * b + nums[i]) % mod;
                preP[i + 1] = preP[i] * b % mod;
            }

            int l = 1;
            int r = n;
            while (l < r)
            {
                int mid = (l + r) / 2;

                if (Possible(n, mid, mod, b, preH, preP))
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return l;
        }

        private bool Possible(int n, int length, long mod, long b, long[] preH, long[] preP)
        {
            var counts = new Dictionary<long, int>();

            for (int left = 0; left + length <= n; ++left)
            {
                int right = left + length;

                long key = (preH[right] - preH[left] * preP[length] % mod + mod) % mod;
                counts.TryGetValue(key, out int count);
                counts[key] = count + 1;
            }

            foreach (int times in counts.Values)
            {
                if (times == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
