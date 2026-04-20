using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2078 : IProblem
    {
        public bool Test()
        {
            var colors = new[] { 1, 1, 1, 6, 1, 1, 1 };

            var expected = 3;

            var result = MaxDistance(colors);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxDistance(int[] colors)
        {
            var n = colors.Length;
            var lastDif = n - 1;
            while (colors[lastDif] == colors[0])
                lastDif--;
            var firstDif = 0;
            while (colors[firstDif] == colors[n - 1])
                firstDif++;

            return Math.Max(lastDif, n - firstDif - 1);
        }
    }
}
