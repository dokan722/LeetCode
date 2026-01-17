using Problems.Problems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly174
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };
            var target = new[] { 2, 1, 3 };

            var expected = 2;

            var result = MinOperations(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums, int[] target)
        {
            var n = nums.Length;
            var values = new HashSet<int>();
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] != target[i])
                    values.Add(nums[i]);
            }

            return values.Count;
        }
    }
}
