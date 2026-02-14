using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _822 : IProblem
    {
        public bool Test()
        {
            var fronts = new[] { 1, 2, 4, 4, 7 };
            var backs = new[] { 1, 3, 4, 1, 3 };

            var expected = 2;

            var result = Flipgame(fronts, backs);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Flipgame(int[] fronts, int[] backs)
        {
            var n = fronts.Length;
            var maxVal = 2001;
            var present = new bool[maxVal];
            var impossible = new bool[maxVal];
            for (int i = 0; i < n; ++i)
            {
                present[fronts[i]] = true;
                present[backs[i]] = true;
                if (fronts[i] == backs[i])
                    impossible[fronts[i]] = true;
            }
            var result = maxVal;
            for (int i = 1; i < maxVal; ++i)
            {
                if (present[i] && !impossible[i])
                {
                    result = i;
                    break;
                }
            }

            return result == maxVal ? 0 : result;
        }
    }
}
