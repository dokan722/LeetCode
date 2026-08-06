using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2317 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 4, 6 };

            var expected = 7;

            var result = MaximumXOR(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumXOR(int[] nums)
        {
            var result = 0;
            foreach (var n in nums)
                result |= n;
            return result;
        }
    }
}
