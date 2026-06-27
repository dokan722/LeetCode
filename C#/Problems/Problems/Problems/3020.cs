using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3020 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 4, 1, 2, 2 };

            var expected = 3;

            var result = MaximumLength(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumLength(int[] nums)
        {
            var counts = new Dictionary<long, int>();

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            counts.TryGetValue(1, out int oneCnt);
            int ans = (oneCnt & 1) == 1 ? oneCnt : oneCnt - 1;

            counts.Remove(1);

            foreach (long num in counts.Keys)
            {
                int res = 0;
                long x = num;

                while (counts.TryGetValue(x, out int c) && c > 1)
                {
                    res += 2;
                    x *= x;
                }

                ans = Math.Max(ans, res + (counts.ContainsKey(x) ? 1 : -1));
            }

            return ans;
        }
    }
}
