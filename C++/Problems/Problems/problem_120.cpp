#include "problem_120.h"

bool problem_120::test() {
    std::vector<std::vector<int>> triangle {  { 2 },  { 3, 4 },  { 6, 5, 7 },  { 4, 1, 8, 3 } };

    int expected = 11;

    auto result = minimumTotal(triangle);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_120::minimumTotal(std::vector<std::vector<int>> &triangle) {
    int n = triangle.size();
    for (int i = n - 2; i >= 0; --i)
    {
        for (int j = 0; j <= i; ++j)
            triangle[i][j] += std::min(triangle[i + 1][j], triangle[i + 1][j + 1]);
    }

    return triangle[0][0];
}
