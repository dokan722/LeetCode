#include "problem_1314.h"

bool problem_1314::test() {
    std::vector<std::vector<int>> mat {  { 1, 2, 3 },  { 4, 5, 6 },  { 7, 8, 9 } };
    int k = 1;

    std::vector<std::vector<int>>  expected  {  { 12, 21, 16 },  { 27, 45, 33 },  { 24, 39, 28 } };

    auto result = matrixBlockSum(mat, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_1314::matrixBlockSum(std::vector<std::vector<int>> &mat, int k) {
    int n = mat.size();
    int m = mat[0].size();
    std::vector pref(n, std::vector(m, 0));
    std::vector result(n, std::vector(m, 0));

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int left = i > 0 ? pref[i - 1][j] : 0;
            int up = j > 0 ? pref[i][j - 1] : 0;
            int ul = i > 0 && j > 0 ? pref[i - 1][j - 1] : 0;
            pref[i][j] = mat[i][j] + left + up - ul;
        }
    }
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int t = i - k - 1;
            int b = std::min(n - 1, i + k);
            int l = j - k - 1;
            int r = std::min(m - 1, j + k);
            int total = pref[b][r];
            int left = l >= 0 ? pref[b][l] : 0;
            int up = t >= 0 ? pref[t][r] : 0;
            int ul = l >= 0 && t >= 0 ? pref[t][l] : 0;
            result[i][j] = total - left - up + ul;
        }
    }

    return result;
}
