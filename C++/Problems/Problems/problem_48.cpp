#include "problem_48.h"

bool problem_48::test() {
    std::vector<std::vector<int>> matrix { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    std::vector<std::vector<int>> expected { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };

    rotate(matrix);

    print2DVector(matrix);

    return expected == matrix;
}

void problem_48::rotate(std::vector<std::vector<int>> &matrix) {
    int n = matrix.size();
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n - 1 - i; j++)
        {
            int tmp = matrix[i][j];
            matrix[i][j] = matrix[n - 1 - j][i];
            matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
            matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
            matrix[j][n - 1 - i] = tmp;
        }
    }
}
