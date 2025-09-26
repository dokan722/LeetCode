using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3038 : IProblem
    {
        public bool Test()
        {
            var colors = "AAABABB";

            var expected = true;

            var result = WinnerOfGame(colors);

            return expected == result;
        }

        public bool WinnerOfGame(string colors)
        {
            var n = colors.Length;
            var aliceMoves = 0;
            var bobMoves = 0;
            for (int i = 1; i < n - 1; ++i)
            {
                if (colors[i - 1] == colors[i] && colors[i] == colors[i + 1])
                {
                    if (colors[i] == 'A')
                        aliceMoves++;
                    else
                        bobMoves++;
                }
            }

            return aliceMoves > bobMoves;
        }
    }
}
