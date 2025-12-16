#include "problem_2661.h"

bool problem_2661::test() {
    std::vector arr { 2, 8, 7, 4, 1, 3, 5, 6, 9 };
    std::vector<std::vector<int>> mat { { 3, 2, 5 }, { 1, 4, 6 }, { 8, 7, 9 } };

    int expected = 3;

    auto result = firstCompleteIndex(arr, mat);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2661::firstCompleteIndex(std::vector<int> &arr, std::vector<std::vector<int>> &mat) {
    int n = mat.size();
    int m = mat[0].size();
    int nm = n * m;
    std::vector<std::pair<int, int>> pos(nm + 1);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            pos[mat[i][j]] = std::pair(i, j);
    }

    std::vector rows(n, 0);
    std::vector cols(m, 0);
    for (int i = 0; i < nm; ++i)
    {
        auto p = pos[arr[i]];
        rows[p.first]++;
        cols[p.second]++;
        if (rows[p.first] == m || cols[p.second] == n)
            return i;
    }

    return -1;
}
