using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1608 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 5 };

            var expected = 2;

            var result = SpecialArray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SpecialArray(int[] nums)
        {
            var counts = new int[1001];
            foreach (var n in nums)
                counts[n]++;
            var cur = 0;
            for (int i = 1000; i >= 0; --i)
            {
                cur += counts[i];
                if (cur == i)
                    return i;
                if (cur > i)
                    break;
            }

            return -1;
        }
    }
}
