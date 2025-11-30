#include "problem_2017.h"

bool problem_2017::test() {
    std::vector<std::vector<int>> grid { { 2, 5, 4 }, { 1, 5, 1 } };

    int expected = 4;

    auto result = gridGame(grid);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2017::gridGame(std::vector<std::vector<int>> &grid) {
    int n = grid[0].size();
    std::vector<long long> sums { 0, 0 };
    for (int i = 0; i < n; i++)
    {
        sums[0] += grid[0][i];
        sums[1] += grid[1][i];
    }

    long long result = sums[0] - grid[0][0];
    std::vector<long long> prefs { grid[0][0], 0 };
    for (int i = 1; i < n; i++)
    {
        prefs[0] += grid[0][i];
        prefs[1] += grid[1][i - 1];
        result = std::min(result, std::max(sums[0] - prefs[0], prefs[1]));
    }

    return result;
}
