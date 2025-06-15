//
// Created by peite on 15.06.2025.
//

#include "problem_1572.h"

#include <iostream>
#include <ostream>

bool problem_1572::test() {
    std::vector<std::vector<int>> nums { { 1, 2, 3 },  { 4, 5, 6 }, {7, 8, 9} };

    auto expected = 25;

    auto result = diagonalSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1572::diagonalSum(std::vector<std::vector<int>> &mat) {
    auto size = mat.size();
    auto sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += mat[i][i];
        sum += mat[i][size - i - 1];
    }

    if (size % 2 == 1)
        sum -= mat[size / 2][size / 2];

    return sum;
}
