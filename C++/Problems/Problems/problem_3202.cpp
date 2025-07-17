#include "problem_3202.h"

bool problem_3202::test() {
    std::vector nums { 1, 4, 2, 3, 1, 4 };
    auto k = 3;

    auto expected = 4;

    auto result = maximumLength(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3202::maximumLength(std::vector<int> &nums, int k) {
    std::vector<std::vector<int>> lengths(k);

    for (int i = 0; i < k; i++) {
        lengths[i] = std::vector(k, 0);
    }

    for (int i = 0; i < nums.size(); i++)
    {
        auto mod = nums[i] % k;
        for (int j = 0; j < k; ++j)
            lengths[mod][j] = lengths[j][mod] + 1;
    }

    auto result = INT_MIN;
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < k; ++j)
        {
            if (lengths[i][j] > result)
                result = lengths[i][j];
        }
    }

    return result;
}
