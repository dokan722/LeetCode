#include "problem_1886.h"

bool problem_1886::test() {
    std::vector<std::vector<int>> mat  {{0, 1}, {1, 0}};
    std::vector<std::vector<int>> target = { { 1, 0 }, { 0, 1 } };

    bool expected = true;

    auto result = findRotation(mat, target);

    return result == expected;
}

bool problem_1886::findRotation(std::vector<std::vector<int>> &mat, std::vector<std::vector<int>> &target) {
    int n = mat.size();
    int poss = 0b1111;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (mat[i][j] != target[i][j])
                poss &= 0b0111;
            if (mat[j][n - 1 - i] != target[i][j])
                poss &= 0b1011;
            if (mat[n - 1 - i][n - 1 - j] != target[i][j])
                poss &= 0b1101;
            if (mat[n - 1 - j][i] != target[i][j])
                poss &= 0b1110;
            if (poss == 0)
                return false;
        }
    }

    return true;
}
