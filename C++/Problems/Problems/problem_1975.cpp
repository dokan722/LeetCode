#include "problem_1975.h"

bool problem_1975::test() {
    std::vector<std::vector<int>> matrix { { 1, -1 }, { -1, 1 } };

    int expected = 4;

    auto result = maxMatrixSum(matrix);

    std::cout << result << std::endl;

    return result == expected;;
}

long long problem_1975::maxMatrixSum(std::vector<std::vector<int>> &matrix) {
    int min = INT_MAX;
    long sum = 0;
    bool even = true;
    int n = matrix.size();
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (matrix[i][j] < 0)
                even = !even;
            int num = std::abs(matrix[i][j]);
            min = std::min(min, num);
            sum += num;
        }
    }

    return sum - (even ? 0 : 2 * min);
}
