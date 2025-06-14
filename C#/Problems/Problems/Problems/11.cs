using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _11 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var expected = 49;

            var result = MaxArea(nums);

            return expected == result;
        }

        public int MaxArea(int[] height)
        {
            var maxWater = 0;
            var left = 0;
            var right = height.Length - 1;
            while (left < right)
            {
                var water = (right - left) * Math.Min(height[left], height[right]);
                if (water > maxWater)
                    maxWater = water;
                if (height[left] < height[right])
                    left += 1;
                else
                    right -= 1;
            }

            return maxWater;
        }
    }
}
