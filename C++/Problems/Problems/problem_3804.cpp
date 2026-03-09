#include "problem_3804.h"

#include <unordered_set>

bool problem_3804::test() {
    std::vector nums  { -1, 1, 0 };

    int expected = 5;

    auto result = centeredSubarrays(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3804::centeredSubarrays(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        int sum = 0;
        std::unordered_set<int> present;
        for (int j = i; j < n; ++j)
        {
            sum += nums[j];
            present.insert(nums[j]);
            if (present.contains(sum))
                result++;
        }
    }

    return result;
}
