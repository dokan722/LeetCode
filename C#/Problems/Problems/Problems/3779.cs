using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3779 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 8, 3, 6, 5, 8 };

            var expected = 1;

            var result = MinOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums)
        {
            var n = nums.Length;
            var present = new HashSet<int>();
            for (int i = n - 1; i >= 0; --i)
            {
                if (present.Contains(nums[i]))
                    return (i + 1 + 2) / 3;
                present.Add(nums[i]);
            }

            return 0;
        }
    }
}
