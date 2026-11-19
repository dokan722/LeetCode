using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3909 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2, 1 };

            var expected = 1;

            var result = CompareBitonicSums(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CompareBitonicSums(int[] nums)
        {
            var n = nums.Length;
            if (nums[1] < nums[0])
                return 1;
            if (nums[n - 1] > nums[n - 2])
                return 0;
            var i = 0;
            long pre = 0;
            while (nums[i + 1] > nums[i])
            {
                pre += nums[i];
                i++;
            }
            pre += nums[i];
            long suf = 0;
            for (int j = i; j < n; ++j)
                suf += nums[j];
            if (pre > suf)
                return 0;
            if (pre < suf)
                return 1;
            return -1;
        }
    }
}
