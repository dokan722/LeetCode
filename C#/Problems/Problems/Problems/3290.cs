using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3290 : IProblem
    {
        public bool Test()
        {
            var a = new[] { -1, 4, 5, -2 };
            var b = new[] { -5, -1, -3, -2, -4 };

            var expected = -1;

            var result = MaxScore(a, b);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxScore(int[] a, int[] b)
        {
            var n = b.Length;
            var result = new long[] { (long)100 * int.MinValue, (long)100 * int.MinValue, (long)100 * int.MinValue, (long)100 * int.MinValue };
            for (int i = 0; i < n; ++i)
            {
                var next = new long[4];
                next[0] = Math.Max(result[0], (long)a[0] * b[i]);
                next[1] = Math.Max(result[1], result[0] + (long)a[1] * b[i]);
                next[2] = Math.Max(result[2], result[1] + (long)a[2] * b[i]);
                next[3] = Math.Max(result[3], result[2] + (long)a[3] * b[i]);
                result = next;
            }

            return result[3];
        }
    }
}
