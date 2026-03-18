using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _806 : IProblem
    {
        public bool Test()
        {
            var widths = new[] {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
            var s = "abcdefghijklmnopqrstuvwxyz";

            var expected = new[] { 3, 60 };

            var result = NumberOfLines(widths, s);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] NumberOfLines(int[] widths, string s)
        {
            var lines = 1;
            var pixels = 0;
            foreach (var c in s)
            {
                var cl = widths[c - 'a'];
                if (pixels + cl <= 100)
                    pixels += cl;
                else
                {
                    lines++;
                    pixels = cl;
                }
            }

            return new int[] { lines, pixels };
        }
    }
}
