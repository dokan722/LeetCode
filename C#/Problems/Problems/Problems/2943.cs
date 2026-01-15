using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2943 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var m = 3;
            var hBars = new[] { 2, 3 };
            var vBars = new[] { 2, 4 };

            var expected = 4;

            var result = MaximizeSquareHoleArea(n, m, hBars, vBars);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars)
        {
            Array.Sort(hBars);
            Array.Sort(vBars);
            var hn = hBars.Length;
            var vn = vBars.Length;

            var curr = 1;
            var hm = 1;
            for (int i = 1; i < hn; ++i)
            {
                if (hBars[i] == hBars[i - 1] + 1)
                    curr++;
                else
                    curr = 1;
                hm = Math.Max(hm, curr);
            }

            curr = 1;
            var vm = 1;
            for (int i = 1; i < vn; ++i)
            {
                if (vBars[i] == vBars[i - 1] + 1)
                    curr++;
                else
                    curr = 1;
                vm = Math.Max(vm, curr);
            }

            var side = Math.Min(hm, vm) + 1;

            return side * side;
        }
    }
}
