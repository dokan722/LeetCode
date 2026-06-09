using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2568 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1 };

            var expected = 4;

            var result = MinImpossibleOR(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinImpossibleOR(int[] nums)
        {
            var s = new HashSet<int>();
            foreach (var num in nums)
                s.Add(num);
            var result = 1;
            while (s.Contains(result))
                result *= 2;
            return result;
        }
    }
}
