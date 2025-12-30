#include "problem_2610.h"

bool problem_2610::test() {
    std::vector nums { 1, 3, 4, 1, 2, 3, 1 };

    std::vector<std::vector<int>> expected { { 1, 3, 4, 2 }, { 1, 3 }, { 1 } };

    auto result = findMatrix(nums);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_2610::findMatrix(std::vector<int> &nums) {
    std::vector counts(201, 0);
    std::vector<std::vector<int>> result;
    for (int num : nums)
    {
        int row = counts[num];
        if (result.size() <= row)
            result.push_back(std::vector { num });
        else
            result[row].push_back(num);
        counts[num]++;
    }

    return result;
}
