using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3487 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, -1, -2, 1, 0, -1 };

            var expected = 3;

            var result = MaxSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSum(int[] nums)
        {
            var valuesSet = new HashSet<int>();
            var max = nums[0];
            foreach (var num in nums)
            {
                if (num > 0)
                    valuesSet.Add(num);
                if (max < num)
                    max = num;

            }

            if (max < 0)
                return max;

            return valuesSet.Sum();
        }
    }
}
