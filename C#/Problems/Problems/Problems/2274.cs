using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2274 :IProblem
    {
        public bool Test()
        {
            var bottom = 2;
            var top = 9;
            var special = new[] { 4, 6 };

            var expected = 3;

            var result = MaxConsecutive(bottom, top, special);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxConsecutive(int bottom, int top, int[] special)
        {
            var start = bottom;
            Array.Sort(special);
            var max = int.MinValue;
            foreach (var s in special)
            {
                var len = s - start;
                if (len > max)
                    max = len;
                start = s + 1;
            }

            var last = top - start + 1;

            return Math.Max(last, max);
        }
    }
}
