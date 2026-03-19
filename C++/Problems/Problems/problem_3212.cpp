#include "problem_3212.h"

bool problem_3212::test() {
    std::vector<std::vector<char>> grid { { 'X', 'Y', '.' }, { 'Y', '.', '.' } };

    int expected = 3;

    auto result = numberOfSubmatrices(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3212::numberOfSubmatrices(std::vector<std::vector<char>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector xs(n, std::vector(m, 0));
    std::vector ys(n, std::vector(m, 0));

    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int upx = i > 0 ? xs[i - 1][j] : 0;
            int leftx = j > 0 ? xs[i][j - 1] : 0;
            int lastx = i > 0 && j > 0 ? xs[i - 1][j - 1] : 0;
            xs[i][j] = upx + leftx - lastx + (grid[i][j] == 'X' ? 1 : 0);
            int upy = i > 0 ? ys[i - 1][j] : 0;
            int lefty = j > 0 ? ys[i][j - 1] : 0;
            int lasty = i > 0 && j > 0 ? ys[i - 1][j - 1] : 0;
            ys[i][j] = upy + lefty - lasty + (grid[i][j] == 'Y' ? 1 : 0);
            if (xs[i][j] != 0 && xs[i][j] == ys[i][j])
                result++;
        }
    }

    return result;
}
