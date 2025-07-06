using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2212 : IProblem
    {
        public bool Test()
        {
            var numArrows = 9;
            var aliceArrows = new[] { 1, 1, 0, 1, 0, 0, 2, 1, 0, 1, 2, 0 };

            var expected = new[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 2, 3, 1 };

            var result = MaximumBobPoints(numArrows, aliceArrows);

            return expected.SequenceEqual(result);
        }

        public int[] MaximumBobPoints(int numArrows, int[] aliceArrows)
        {
            var n = aliceArrows.Length;
            var reqArrows = new int[n];
            for (int i = 0; i < n; i++)
            {
                reqArrows[i] = aliceArrows[i] + 1;
            }

            var bestResult = int.MinValue;
            var bestArrows = new int[n];

            for (int i = 1; i < 1 << 12; ++i)
            {
                var remArrows = numArrows;
                var currPoints = 0;
                var currArrows = new int[n];
                var values = TransformToBitArray(i);
                for (int j = 0; j < n; ++j)
                {
                    if (values[j] == 1)
                    {
                        currPoints += j;
                        remArrows -= reqArrows[j];
                        currArrows[j] = reqArrows[j];
                    }

                    if (currPoints > bestResult && remArrows >= 0)
                    {
                        currArrows[n - 1] += remArrows;
                        bestResult = currPoints;
                        bestArrows = currArrows;
                    }
                }
            }

            return bestArrows;
        }

        private int[] TransformToBitArray(int num)
        {
            int[] bits = new int[12];

            for (int i = 11; i >= 0; i--)
            {
                bits[11 - i] = (num >> i) & 1;
            }

            return bits;
        }
    }
}
