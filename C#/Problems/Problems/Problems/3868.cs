using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3868 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 10, 20 };
            var nums2 = new[] { 20, 10 };

            var expected = 0;

            var result = MinCost(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinCost(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var counts = new Dictionary<int, int>();
            for (int i = 0; i < n; ++i)
            {
                if (counts.ContainsKey(nums1[i]))
                    counts[nums1[i]]++;
                else
                    counts[nums1[i]] = 1;
                if (counts.ContainsKey(nums2[i]))
                    counts[nums2[i]]--;
                else
                    counts[nums2[i]] = -1;
            }

            var result = 0;
            foreach (var count in counts)
            {
                var val = Math.Abs(count.Value);
                if (val % 2 != 0)
                    return -1;
                result += val / 2;
            }

            return result / 2;
        }
    }
}
