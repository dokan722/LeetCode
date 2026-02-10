#include "problem_3719.h"

#include <unordered_set>

bool problem_3719::test() {
    std::vector nums  { 3, 2, 2, 5, 4 };

    int expected = 5;

    auto result = longestBalanced(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3719::longestBalanced(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        std::unordered_set<int> even;
        std::unordered_set<int> odd;
        for (int j = i; j < n; ++j)
        {
            if (nums[j] % 2 == 0)
                even.insert(nums[j]);
            else
                odd.insert(nums[j]);
            if (even.size() == odd.size())
                result = std::max(result, j - i + 1);
        }
    }

    return result;
}
