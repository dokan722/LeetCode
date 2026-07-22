#include "problem_1260.h"

bool problem_1260::test() {
    std::vector<std::vector<int>> grid { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int k = 1;

    std::vector<std::vector<int>> expected { { 9, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

    auto result = shiftGrid(grid, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_1260::shiftGrid(std::vector<std::vector<int>> &grid, int k) {
    if (k == 0)
        return grid;
    int n = grid.size();
    int m = grid[0].size();
    int t = n * m;
    k %= t;
    revGrid(grid, 0, t - 1, m);
    revGrid(grid, 0, k - 1, m);
    revGrid(grid, k, t - 1, m);

    return grid;
}

void problem_1260::revGrid(std::vector<std::vector<int>>& grid, int l, int r, int m) {
    while (l < r)
    {
        int lx = l / m;
        int ly = l % m;
        int rx = r / m;
        int ry = r % m;
        std::swap(grid[rx][ry], grid[lx][ly]);
        l++;
        r--;
    }
}
