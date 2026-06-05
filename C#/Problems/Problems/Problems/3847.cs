using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3847 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };

            var expected = 0;

            var result = ScoreDifference(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ScoreDifference(int[] nums)
        {
            var n = nums.Length;
            var det = 1;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] % 2 == 1)
                    det *= -1;
                if (i % 6 == 5)
                    det *= -1;
                result += nums[i] * det;
            }

            return result;
        }
    }
}
