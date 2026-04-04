using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3659 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var k = 2;

            var expected = true;

            var result = PartitionArray(nums, k);

            return result == expected;
        }

        public bool PartitionArray(int[] nums, int k)
        {
            var n = nums.Length;
            if (n % k != 0)
                return false;
            var groups = n / k;
            var counts = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
                if (counts[num] > groups)
                    return false;
            }

            return true;
        }
    }
}
