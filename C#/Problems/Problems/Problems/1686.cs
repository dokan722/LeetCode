using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1686 : IProblem
    {
        public bool Test()
        {
            var aliceValues = new[] { 1, 3 };
            var bobValues = new[] { 2, 1 };

            var expected = 1;

            var result = StoneGameVI(aliceValues, bobValues);

            Console.WriteLine(result);

            return result == expected;
        }

        public int StoneGameVI(int[] aliceValues, int[] bobValues)
        {
            var n = aliceValues.Length;
            var counts = new int[201];
            var totalb = 0;
            for (int i = 0; i < n; ++i)
            {
                var s = aliceValues[i] + bobValues[i];
                counts[s]++;
                totalb += bobValues[i];
            }
            var turn = 0;
            var a = 0;
            for (int i = 200; i >= 0; --i)
            {
                var c = counts[i];
                a += i * ((c + (turn % 2 == 0 ? 1 : 0)) / 2);
                turn += c;
            }
            var res = a - totalb;
            if (res > 0)
                return 1;
            if (res < 0)
                return -1;
            return 0;
        }
    }
}
