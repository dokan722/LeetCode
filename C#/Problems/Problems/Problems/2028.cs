using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2028 : IProblem
    {
        public bool Test()
        {
            var rolls = new[] { 3, 2, 4, 3 };
            var mean = 4;
            var n = 2;

            var expected = new[] { 6, 6 };

            var result = MissingRolls(rolls, mean, n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            var m = rolls.Length;
            var req = (n + m) * mean;
            foreach (var r in rolls)
                req -= r;
            req -= n;
            if (req < 0)
                return new int[] { };
            var result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                if (req <= 0)
                    result[i] = 1;
                else
                {
                    var big = Math.Min(req, 5);
                    result[i] = big + 1;
                    req -= big;
                }
            }

            return req <= 0 ? result : new int[] { };
        }
    }
}
