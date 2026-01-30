#include "problem_1004.h"

bool problem_1004::test() {
    std::vector nums  { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };

    int k = 2;

    int expected = 6;

    auto result = longestOnes(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1004::longestOnes(std::vector<int> &nums, int k) {
    int n = nums.size();
    int left = 0;
    int zeros = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == 0)
            zeros++;
        while (zeros > k && left <= i)
        {
            if (nums[left] == 0)
                zeros--;
            left++;
        }
        result = std::max(result, i - left + 1);
    }

    return result;
}
