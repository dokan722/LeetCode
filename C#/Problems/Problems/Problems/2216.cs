using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2216 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 2, 3, 5 };

            var expected = 1;

            var result = MinDeletion(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinDeletion(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
                return 1;
            var result = 0;
            var i = 0;
            var j = 1;
            while (j < n)
            {
                if (nums[i] == nums[j])
                {
                    result++;
                    j++;
                }
                else
                {
                    i = j + 1;
                    j += 2;
                }
            }
            if ((n - result) % 2 != 0)
                result++;
            return result;
        }
    }
}
