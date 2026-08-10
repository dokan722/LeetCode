#include "problem_576.h"

bool problem_576::test() {
    int m = 2;
    int n = 2;
    int maxMove = 2;
    int startRow = 0;
    int startColumn = 0;

    int expected = 6;

    auto result = findPaths(m, n, maxMove, startRow, startColumn);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_576::findPaths(int m, int n, int maxMove, int startRow, int startColumn) {
    std::vector cur(m, std::vector<long long>(n, 0));
    cur[startRow][startColumn] = 1;
    long long result = 0;
    int mod = 1000000007;
    for (int i = 0; i < maxMove; ++i)
    {
        for (int j = 0; j < m; ++j)
            result = (result + cur[j][0] + cur[j][n - 1]) % mod;
        for (int j = 0; j < n; ++j)
            result = (result + cur[0][j] + cur[m - 1][j]) % mod;
        std::vector next(m, std::vector<long long>(n, 0));
        for (int j = 0; j < m; ++j)
        {
            for (int k = 0; k < n; ++k)
            {
                long long up = j > 0 ? cur[j - 1][k] : 0;
                long long down = j < m - 1 ? cur[j + 1][k] : 0;
                long long left = k > 0 ? cur[j][k - 1] : 0;
                long long right = k < n - 1 ? cur[j][k + 1] : 0;
                next[j][k] = (up + down + left + right) % mod;
            }
        }
        cur = next;
    }

    return (int)result;
}
