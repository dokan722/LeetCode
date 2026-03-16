using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1760 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 4, 8, 2 };
            var maxOperations = 4;

            var expected = 2;

            var result = MinimumSize(nums, maxOperations);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumSize(int[] nums, int maxOperations)
        {
            var n = nums.Length;
            var left = 1;
            var right = int.MinValue;
            for (int i = 0; i < n; ++i)
                right = Math.Max(nums[i], right);
            while (left < right)
            {
                var mid = (left + right) / 2;
                var possible = true;
                var operationsLeft = maxOperations;
                for (int i = 0; i < n; ++i)
                {
                    var needed = ((nums[i] + mid - 1) / mid) - 1;
                    operationsLeft -= needed;
                    if (operationsLeft < 0)
                    {
                        possible = false;
                        break;
                    }
                }
                if (possible)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
