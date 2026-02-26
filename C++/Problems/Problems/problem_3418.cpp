#include "problem_3418.h"

bool problem_3418::test() {
    std::vector<std::vector<int>> coins { {-7, 12, 12, 13},  {-6, 19, 19, -6}, {9, -2, -10, 16}, {-4, 14, -10, -9}};

    int expected = 60;

    auto result = maximumAmount(coins);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3418::maximumAmount(std::vector<std::vector<int>> &coins) {
    int n = coins.size();
    int m = coins[0].size();
    int l = 3;
    std::vector paths(n, std::vector(m, std::vector(l, 0)));

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (i == 0 && j == 0)
            {
                paths[i][j][0] = coins[0][0];
                for (int k = 1; k < l; ++k)
                    paths[i][j][k] = std::max(0, coins[0][0]);
            }
            else
            {
                int up = i > 0 ? paths[i - 1][j][0] : INT_MIN;
                int left = j > 0 ? paths[i][j - 1][0] : INT_MIN;
                paths[i][j][0] = std::max(up, left) + coins[i][j];
                for (int k = 1; k < l; ++k)
                {
                    up = i > 0 ? paths[i - 1][j][k - 1] : INT_MIN;
                    left = j > 0 ? paths[i][j - 1][k - 1] : INT_MIN;
                    int upStay = i > 0 ? paths[i - 1][j][k] : INT_MIN;
                    int leftStay = j > 0 ? paths[i][j - 1][k] : INT_MIN;
                    paths[i][j][k] = std::max(std::max(upStay, leftStay) + coins[i][j], std::max(up, left) + std::max(0, coins[i][j]));
                }
            }
        }
    }

    return paths[n - 1][m - 1][l - 1];
}
