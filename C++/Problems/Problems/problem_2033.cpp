#include "problem_2033.h"

bool problem_2033::test() {
    std::vector<std::vector<int>> grid  { { 2, 4 }, { 6, 8 } };
    int x = 2;

    int expected = 4;

    auto result = minOperations(grid, x);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2033::minOperations(std::vector<std::vector<int>> &grid, int x) {
    int n = grid.size();
    int m = grid[0].size();
    int exp = grid[0][0] % x;
    std::vector<int> freqs(100001 / x + 1, 0);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] % x != exp)
                return -1;
            freqs[grid[i][j] / x]++;
        }
    }
    int mid = (m * n + 1) / 2;
    int count = 0;
    int median = 0;
    for (int i = 0; i < freqs.size(); ++i)
    {
        count += freqs[i];
        if (count >= mid)
        {
            median = i;
            break;
        }
    }
    int result = 0;
    for (int i = 0; i < freqs.size(); ++i)
    {
        result += std::abs(i - median) * freqs[i];
    }

    return result;
}
