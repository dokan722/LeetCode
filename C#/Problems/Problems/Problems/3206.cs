using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3206 : IProblem
    {
        public bool Test()
        {
            var colors = new[] { 0, 1, 0, 0, 1 };

            var expected = 3;

            var result = NumberOfAlternatingGroups(colors);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfAlternatingGroups(int[] colors)
        {
            var n = colors.Length;
            var result = 0;
            var p = colors[n - 1];
            var pp = colors[n - 2];
            for (int i = 0; i < n; ++i)
            {
                if (p != pp && p != colors[i])
                    result++;
                pp = p;
                p = colors[i];
            }

            return result;
        }
    }
}
