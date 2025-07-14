using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1007 : IProblem
    {
        public bool Test()
        {
            var tops = new int[] { 2, 1, 2, 4, 2, 2 };
            var bottoms = new int[] { 5, 2, 6, 2, 3, 2 };

            var expected = 2;

            var result = MinDominoRotations(tops, bottoms);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            var n = tops.Length;
            var possDomi = 6;
            var upperNums = new int[possDomi];
            var lowerNums = new int[possDomi];
            var sameNumber = -1;
            var same = 0;
            for (int i = 0; i < n; i++)
            {
                if (tops[i] != bottoms[i])
                {
                    upperNums[tops[i] - 1]++;
                    lowerNums[bottoms[i] - 1]++;
                }
                else
                {
                    if (sameNumber != -1 && sameNumber != tops[i])
                        return -1;
                    sameNumber = tops[i];
                    same++;
                }
            }

            if (sameNumber != -1)
            {
                if (upperNums[sameNumber - 1] + lowerNums[sameNumber - 1] == n - same)
                    return Math.Min(upperNums[sameNumber - 1], lowerNums[sameNumber - 1]);
                return -1;
            }
            for (int i = 0; i < possDomi; i++)
            {
                if (upperNums[i] + lowerNums[i] == n)
                    return Math.Min(upperNums[i], lowerNums[i]);
            }

            return -1;
        }
    }
}
