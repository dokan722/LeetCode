using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1301 : IProblem
    {
        public bool Test()
        {
            var board = new[] { "E23", "2X2", "12S" };

            var expected = new[] { 7, 1 };

            var result = PathsWithMaxScore(board);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] PathsWithMaxScore(IList<string> board)
        {
            var n = board.Count;
            var mxs = new int[n][];
            var cnts = new int[n][];
            var mod = 1000000007;
            for (int i = 0; i < n; ++i)
            {
                mxs[i] = new int[n];
                cnts[i] = new int[n];
            }
            mxs[n - 1][n - 1] = 0;
            cnts[n - 1][n - 1] = 1;
            for (int i = n - 1; i >= 0; --i)
            {
                for (int j = n - 1; j >= 0; --j)
                {
                    var canDown = i != n - 1;
                    var canRight = j != n - 1;
                    if (board[i][j] != 'X' && (canDown || canRight))
                    {
                        var downMx = canDown ? mxs[i + 1][j] : 0;
                        var rightMx = canRight ? mxs[i][j + 1] : 0;
                        var crossMx = canDown && canRight ? mxs[i + 1][j + 1] : 0;
                        var best = Math.Max(Math.Max(downMx, rightMx), crossMx);
                        long downCnt = canDown && (downMx == best) ? cnts[i + 1][j] : 0;
                        long rightCnt = canRight && (rightMx == best) ? cnts[i][j + 1] : 0;
                        long crossCnt = canRight && canDown && (crossMx == best) ? cnts[i + 1][j + 1] : 0;
                        int curCnt = (int)((downCnt + rightCnt + crossCnt) % mod);
                        var curVal = board[i][j] != 'E' ? board[i][j] - '0' : 0;
                        mxs[i][j] = curCnt != 0 ? best + curVal : 0;
                        cnts[i][j] = curCnt;
                    }
                }
            }

            return new[] { mxs[0][0], cnts[0][0] };
        }
    }
}
