using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3354 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 2, 0, 3 };

            var expected = 2;

            var result = CountValidSelections(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountValidSelections(int[] nums)
        {
            var n = nums.Length;
            var s = 0;
            foreach (var num in nums)
                s += num;

            var result = 0;
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                curr += nums[i];
                if (nums[i] == 0)
                {
                    var diff = Math.Abs(2 * curr - s);
                    result += 2 - Math.Min(diff, 2);
                }
                
            }

            return result;
        }
    }
}
