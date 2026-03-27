#include "problem_2946.h"

bool problem_2946::test() {
    std::vector<std::vector<int>> mat {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
    int k = 4;

    bool expected = false;

    auto result = areSimilar(mat, k);

    std::cout << result << std::endl;

    return result == expected;
}

bool problem_2946::areSimilar(std::vector<std::vector<int>> &mat, int k) {
    int n = mat.size();
    int m = mat[0].size();
    if (k == m || k == 0)
        return true;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (i % 2 == 0)
            {
                if (mat[i][j] != mat[i][((j - k) % m + m) % m])
                    return false;
            }
            else
            {
                if (mat[i][j] != mat[i][(j + k) % m])
                    return false;
            }
        }
    }

    return true;
}
