using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2221 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };

            var expected = 8;

            var result = TriangularSum(nums);
            
            Console.WriteLine(result);

            return expected == result;
        }

        public int TriangularSum(int[] nums)
        {
            var n = nums.Length;
            for (int i = 1; i < n; ++i)
            {
                for (int j = 0; j < n - i; ++j)
                    nums[j] = (nums[j] + nums[j + 1]) % 10;
            }

            return nums[0];
        }
    }
}
