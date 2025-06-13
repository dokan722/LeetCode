using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2616 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 3, 4, 2, 3, 2, 1, 2 };

            var p = 3;

            var expected = 1;

            var result = MinimizeMax(nums, p);

            return expected == result;
        }

        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            var left = 0;
            var right = nums[nums.Length - 1] - nums[0];

            while (left < right)
            {
                var mid = (left + right) / 2;
                var count = CountDiffs(nums, mid);
                if (count < p)
                    left = mid + 1;
                else
                    right = mid;
            }


            return left;
        }

        private int CountDiffs(int[] nums, int maxDiff)
        {
            var count = 0;
            for (int i = 0; i <  nums.Length - 1; i++)
            {
                if (Math.Abs(nums[i] - nums[i + 1]) <= maxDiff)
                {
                    i++;
                    count++;
                }
            }

            return count;
        }
    }
}
