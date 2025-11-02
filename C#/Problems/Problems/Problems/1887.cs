using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1887 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 2, 2, 3 };
            
            var expected = 4;

            var result = ReductionOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ReductionOperations(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            var result = 0;
            for (int i = n - 2; i >= 0; --i)
            {
                if (nums[i] != nums[i + 1])
                    result += n - i - 1;
            }

            return result;
        }
    }
}
