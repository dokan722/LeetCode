using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2598 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -10, 7, 13, 6, 8 };
            var value = 5;

            var expected = 4;

            var result = FindSmallestInteger(nums, value);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindSmallestInteger(int[] nums, int value)
        {
            var n = nums.Length;
            var counts = new int[value];

            for (int i = 0; i < n; i++)
                counts[(nums[i] % value + value) % value]++;

            var minCount = int.MaxValue;
            var minValue = int.MaxValue;
            for (int i = 0; i < value; ++i)
            {
                if (counts[i] < minCount)
                {
                    minCount = counts[i];
                    minValue = i;
                }
            }

            return value * minCount + minValue;
        }
    }
}
