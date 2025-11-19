using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2154 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 3, 6, 1, 12 };
            var original = 3;

            var expected = 24;

            var result = FindFinalValue(nums, original);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindFinalValue(int[] nums, int original)
        {
            var numsSet = new HashSet<int>(nums);
            while (numsSet.Contains(original))
            {
                original <<= 1;
            }

            return original;
        }
    }
}
