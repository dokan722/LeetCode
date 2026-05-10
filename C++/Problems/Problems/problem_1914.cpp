#include "problem_1914.h"

bool problem_1914::test() {
    std::vector<std::vector<int>> grid  { { 40, 10 }, { 30, 20 } };
    int k = 1;

    std::vector<std::vector<int>> expected { { 10, 20 }, { 40, 30 } };

    auto result = rotateGrid(grid, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_1914::rotateGrid(std::vector<std::vector<int>> &grid, int k) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector result(n, std::vector<int>(n));

    for (int i = 0; i < std::min(n, m) / 2; ++i)
    {
        int layerH = n - 2 * i;
        int layerW = m - 2 * i;
        int layerLen = 2 * layerH + 2 * layerW - 4;
        int d = k % layerLen;
        for (int j = 0; j < layerLen; ++j)
        {
            auto resCord = getCoords(i, j, layerW, layerH, n, m);
            auto orgCord = getCoords(i, (j + d) % layerLen, layerW, layerH, n, m);
            result[resCord.first][resCord.second] = grid[orgCord.first][orgCord.second];
        }
    }

    return result;
}

std::pair<int, int> problem_1914::getCoords(int layerNum, int pos, int layerW, int layerH, int h, int w) {
    int x = 0;
    int y = 0;
    if (pos < layerW)
    {
        x = layerNum;
        y = layerNum + pos;
    }
    else if (pos < layerW + layerH - 1)
    {
        x = layerNum + (pos - layerW + 1);
        y = w - 1 - layerNum;
    }
    else if (pos < 2 * layerW + layerH - 2)
    {
        x = h - layerNum - 1;
        y = w - 1 - layerNum - (pos - layerW - layerH + 2);
    }
    else
    {
        x = h - 1 - layerNum - (pos - 2 * layerW - layerH + 3);
        y = layerNum;
    }

    return std::pair(x, y);
}
