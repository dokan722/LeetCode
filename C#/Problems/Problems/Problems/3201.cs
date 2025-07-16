using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3201 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 1, 1, 2, 1, 2 };

            var expected = 6;

            var result = MaximumLength(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumLength(int[] nums)
        {
            var odds = 0;
            var changes = 1;
            var odd = nums[0] % 2 == 1;
            if (odd)
                odds++;
            for (int i = 1; i < nums.Length; ++i)
            {
                var currOdd = nums[i] % 2 == 1;
                if (currOdd)
                    odds++;
                if (currOdd != odd)
                {
                    changes++;
                    odd = currOdd;
                }
            }

            return Math.Max(Math.Max(changes, odds), nums.Length - odds);
        }
    }
}
