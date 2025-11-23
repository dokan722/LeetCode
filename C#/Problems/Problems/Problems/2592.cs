using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2592 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5, 2, 1, 3, 1 };

            var expected = 4;

            var result = MaximizeGreatness(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximizeGreatness(int[] nums)
        {
            var n = nums.Length;
            if (n < 2)
                return 0;
            Array.Sort(nums);
            var greatness = 0;
            var start = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] != nums[i - 1])
                {
                    var l = i - start;
                    greatness = Math.Min(greatness + l, start);
                    start = i;
                }
            }

            var fl = n - start;
            greatness = Math.Min(greatness + fl, start);

            return greatness;
        }
    }
}
