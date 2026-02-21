#include "problem_304.h"

bool problem_304::test() {
    std::vector<std::vector<int>> matrix {  {3, 0, 1, 4, 2},  {5, 6, 3, 2, 1},  {1, 2, 0, 1, 5},  {4, 1, 0, 1, 7},  {1, 0, 3, 0, 5} };
    NumMatrix numMatrix(matrix);
    if (numMatrix.sumRegion(2, 1, 4, 3) != 8)
        return false;
    if (numMatrix.sumRegion(1, 1, 2, 2) != 11)
        return false;
    if (numMatrix.sumRegion(1, 2, 2, 4) != 12)
        return false;

    return true;
}

problem_304::NumMatrix::NumMatrix(std::vector<std::vector<int>> &matrix) {
    int n = matrix.size();
    int m = matrix[0].size();
    _prefs = std::vector(n, std::vector<int>(m));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int left = j > 0 ? _prefs[i][j - 1] : 0;
            int up = i > 0 ? _prefs[i - 1][j] : 0;
            int extra = i > 0 && j > 0 ? _prefs[i - 1][j - 1] : 0;
            _prefs[i][j] = matrix[i][j] + left + up - extra;
        }
    }
}

int problem_304::NumMatrix::sumRegion(int row1, int col1, int row2, int col2) {
    int left = col1 > 0 ? _prefs[row2][col1 - 1] : 0;
    int up = row1 > 0 ? _prefs[row1 - 1][col2] : 0;
    int extra = col1 > 0 && row1 > 0 ? _prefs[row1 - 1][col1 - 1] : 0;
    return _prefs[row2][col2] - left - up + extra;
}
