#include "problem_1292.h"

bool problem_1292::test() {
    std::vector<std::vector<int>> mat {{ 1, 1, 3, 2, 4, 3, 2 }, { 1, 1, 3, 2, 4, 3, 2 }, { 1, 1, 3, 2, 4, 3, 2}};
    int threshold = 4;

    int expected = 2;

    auto result = maxSideLength(mat, threshold);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1292::maxSideLength(std::vector<std::vector<int>> &mat, int threshold) {
    int n = mat.size();
    int m = mat[0].size();
    std::vector pref(n + 1, std::vector(m + 1, 0));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            pref[i + 1][j + 1] = mat[i][j] + pref[i][j + 1] + pref[i + 1][j] - pref[i][j];
    }

    int l = 0;
    int r = std::min(n, m);
    while (l < r)
    {
        int mid = (l + r + 1) / 2;
        bool possible = false;
        int horizontal = n - mid + 1;
        int vertical = m - mid + 1;
        for (int i = 0; i < horizontal; ++i)
        {
            for (int j = 0; j < vertical; ++j)
            {
                if (pref[i + mid][j + mid] - pref[i + mid][j] - pref[i][j + mid] + pref[i][j] <= threshold)
                {
                    possible = true;
                    break;
                }
            }
            if (possible)
                break;
        }
        if (possible)
            l = mid;
        else
            r = mid - 1;
    }

    return l;
}
