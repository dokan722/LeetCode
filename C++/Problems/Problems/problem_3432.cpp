#include "problem_3432.h"

bool problem_3432::test() {
    std::vector nums { 10, 10, 3, 7, 6 };

    int expected = 4;

    auto result = countPartitions(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3432::countPartitions(std::vector<int> &nums) {
    int n = nums.size();
    int sum = 0;
    for (int i = 0; i < n; i++)
        sum += nums[i];
    int curr = 0;
    int result = 0;
    for (int i = 0; i < n - 1; ++i)
    {
        curr += nums[i];
        if (curr % 2 == (sum - curr) % 2)
            result++;
    }

    return result;
}
