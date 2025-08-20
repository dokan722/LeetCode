#include "problem_1277.h"

bool problem_1277::test() {
    std::vector<std::vector<int>> matrix {  { 0, 1, 1, 1 },  { 1, 1, 1, 1 },  { 0, 1, 1, 1 } };

    auto expected = 15;

    auto result = countSquares(matrix);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1277::countSquares(std::vector<std::vector<int>> &matrix) {
    auto n = matrix.size();
    auto m = matrix[0].size();
    std::vector<std::vector<int>> endingSquares(n);
    for (int i = 0; i < n; ++i)
        endingSquares[i] = std::vector<int>(m, 0);

    auto result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (matrix[i][j] == 0)
                endingSquares[i][j] = 0;
            else
            {
                if (i > 0 && j > 0 && matrix[i][j - 1] == 1 && matrix[i - 1][j] == 1 && matrix[i - 1][j - 1] == 1)
                    endingSquares[i][j] = 1 + std::min(std::min(endingSquares[i][j - 1], endingSquares[i - 1][j]), endingSquares[i - 1][j - 1]);
                else
                    endingSquares[i][j] = 1;
                result += endingSquares[i][j];
            }
        }
    }

    return result;
}
