using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _209 : IProblem
    {
        public bool Test()
        {
            var target = 7;
            var nums = new[] { 2, 3, 1, 2, 4, 3 };

            var expected = 2;

            var result = MinSubArrayLen(target, nums);

            Console.WriteLine(expected);

            return result == expected;
        }

        public int MinSubArrayLen(int target, int[] nums)
        {
            var n = nums.Length;
            var r = 0;
            var sum = 0;
            var result = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                while (r < n && sum < target)
                {
                    sum += nums[r];
                    r++;
                }
                if (r >= n && sum < target)
                    break;
                result = Math.Min(result, r - i);
                sum -= nums[i];
            }

            return result != int.MaxValue ? result : 0;
        }
    }
}
