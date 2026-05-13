#include "problem_1674.h"

bool problem_1674::test() {
    std::vector nums  { 1, 2, 4, 3 };
    int limit = 4;

    int expected = 1;

    auto result = minMoves(nums, limit);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1674::minMoves(std::vector<int> &nums, int limit) {
    std::vector counts(2 * limit + 1, 0);
    std::vector ranges(2 * limit + 2, 0);
    int n = nums.size();
    int l = n / 2;
    for (int i = 0; i < l; ++i)
    {
        int sum = nums[i] + nums[n - 1 - i];
        int left = std::min(nums[i] + 1, nums[n - 1 - i] + 1);
        int right = std::max(limit + nums[i], limit + nums[n - 1 - i]);
        counts[sum]++;
        ranges[left]++;
        ranges[right + 1]--;
    }

    int result = INT_MAX                                                                                                                                            ;
    int inRange = 0;
    for (int i = 0; i <= 2 * limit; ++i)
    {
        inRange += ranges[i];
        int mvs = l * 2 - inRange - counts[i];
        result = std::min(result, mvs);
    }

    return result;
}
