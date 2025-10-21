using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3346 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 33, 3, 86, 86, 114 };
            var k = 20;
            var numOperations = 4;

            var expected = 3;

            var result = MaxFrequency(nums, k, numOperations);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxFrequency(int[] nums, int k, int numOperations)
        {
            Array.Sort(nums);
            var n = nums.Length;
            var left = 0;
            var leftBig = 0;
            var right = 0;
            var rightBig = 0;
            var curr = 0;
            var result = 0;
            while (curr < n)
            {
                var val = nums[curr];
                var start = curr;
                while (curr < n && nums[curr] == val)
                    curr++;
                while (right < n && nums[right] <= val + k)
                    right++;
                while (rightBig < n && nums[rightBig] <= val + k * 2)
                    rightBig++;
                while (nums[left] < val - k)
                    left++;
                while (nums[leftBig] < val - 2 * k)
                    leftBig++;
                var currLen = curr - start;
                var inRange = right - left;
                var inRangeLeft = curr - leftBig;
                var inRangeRight = rightBig - start;
                var makeEqual = currLen + Math.Min(numOperations, inRange - currLen);
                var makeOther = Math.Min(numOperations, Math.Max(inRangeLeft, inRangeRight));
                result = Math.Max(result, Math.Max(makeEqual, makeOther));
            }

            return result;
        }
    }
}
