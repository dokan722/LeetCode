using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1033 : IProblem
    {
        public bool Test()
        {
            var a = 1;
            var b = 2;
            var c = 5;

            var expected = new[] { 1, 2 };

            var result = NumMovesStones(a, b, c);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] NumMovesStones(int a, int b, int c)
        {
            var s = new[] { a, b, c };
            Array.Sort(s);
            var left = s[1] - s[0] - 1;
            var right = s[2] - s[1] - 1;
            var m = 2;
            if (left == 0 && right == 0)
                m = 0;
            else if (left < 2 || right < 2)
                m = 1;
            return new int[] { m, left + right };
        }
    }
}
