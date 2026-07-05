#include "problem_1301.h"

bool problem_1301::test() {
    std::vector<std::string> board { "E23", "2X2", "12S" };

    std::vector expected { 7, 1 };

    auto result = pathsWithMaxScore(board);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1301::pathsWithMaxScore(std::vector<std::string> &board) {
    int n = board.size();
    std::vector mxs(n, std::vector(n, 0));
    std::vector cnts(n, std::vector(n, 0));
    int mod = 1000000007;
    mxs[n - 1][n - 1] = 0;
    cnts[n - 1][n - 1] = 1;
    for (int i = n - 1; i >= 0; --i)
    {
        for (int j = n - 1; j >= 0; --j)
        {
            int canDown = i != n - 1;
            int canRight = j != n - 1;
            if (board[i][j] != 'X' && (canDown || canRight))
            {
                int downMx = canDown ? mxs[i + 1][j] : 0;
                int rightMx = canRight ? mxs[i][j + 1] : 0;
                int crossMx = canDown && canRight ? mxs[i + 1][j + 1] : 0;
                int best = std::max(std::max(downMx, rightMx), crossMx);
                long downCnt = canDown && (downMx == best) ? cnts[i + 1][j] : 0;
                long rightCnt = canRight && (rightMx == best) ? cnts[i][j + 1] : 0;
                long crossCnt = canRight && canDown && (crossMx == best) ? cnts[i + 1][j + 1] : 0;
                int curCnt = (int)((downCnt + rightCnt + crossCnt) % mod);
                int curVal = board[i][j] != 'E' ? board[i][j] - '0' : 0;
                mxs[i][j] = curCnt != 0 ? best + curVal : 0;
                cnts[i][j] = curCnt;
            }
        }
    }

    return  { mxs[0][0], cnts[0][0] };
}
