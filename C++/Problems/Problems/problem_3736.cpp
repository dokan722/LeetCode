#include "problem_3736.h"

bool problem_3736::test() {
    std::vector nums { 2, 1, 3 };

    int expected = 3;

    auto result = minMoves(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3736::minMoves(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    int mx = nums[0];
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] > mx)
        {
            result += (nums[i] - mx) * i;
            mx = nums[i];
        }
        else
            result += mx - nums[i];
    }

    return result;
}
