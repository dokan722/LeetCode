#include "problem_3643.h"

bool problem_3643::test() {
    std::vector<std::vector<int>> grid {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}};
    int x = 1;
    int y = 0;
    int k = 3;

    std::vector<std::vector<int>> expected {{1, 2, 3, 4}, {13, 14, 15, 8}, {9, 10, 11, 12}, {5, 6, 7, 16}};

    auto result = reverseSubmatrix(grid, x, y, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_3643::reverseSubmatrix(std::vector<std::vector<int>> &grid, int x, int y, int k) {
    int n = grid.size();
    int m = grid[0].size();
    int swaps = k / 2;
    for (int i = 0; i < swaps; ++i)
    {
        int up = x + i;
        int down = x + k - i - 1;
        for (int j = 0; j < k; ++j)
            std::swap(grid[down][y + j], grid[up][y + j]);
    }

    return grid;
}
