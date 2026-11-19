using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2567 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 7, 8, 5 };

            var expected = 3;

            var result = MinimizeSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimizeSum(int[] nums)
        {
            var n = nums.Length;
            if (n <= 3)
                return 0;
            var mx = new int[3];
            var mn = new[] { int.MaxValue, int.MaxValue, int.MaxValue };
            foreach (var num in nums)
            {
                if (num <= mn[0])
                {
                    mn[2] = mn[1];
                    mn[1] = mn[0];
                    mn[0] = num;
                }
                else if (num <= mn[1])
                {
                    mn[2] = mn[1];
                    mn[1] = num;
                }
                else if (num < mn[2])
                    mn[2] = num;
                if (num >= mx[0])
                {
                    mx[2] = mx[1];
                    mx[1] = mx[0];
                    mx[0] = num;
                }
                else if (num >= mx[1])
                {
                    mx[2] = mx[1];
                    mx[1] = num;
                }
                else if (num > mx[2])
                    mx[2] = num;
            }
            return Math.Min(mx[0] - mn[2], Math.Min(mx[2] - mn[0], mx[1] - mn[1]));
        }
    }
}
