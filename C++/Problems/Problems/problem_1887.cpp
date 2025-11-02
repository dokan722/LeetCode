#include "problem_1887.h"

#include <algorithm>

bool problem_1887::test() {
    std::vector nums { 1, 1, 2, 2, 3 };

    int expected = 4;

    auto result = reductionOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1887::reductionOperations(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    int result = 0;
    for (int i = n - 2; i >= 0; --i)
    {
        if (nums[i] != nums[i + 1])
            result += n - i - 1;
    }

    return result;
}
