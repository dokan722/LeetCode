#include "problem_2913.h"

bool problem_2913::test() {
    std::vector nums  { 1, 2, 1 };

    int expected = 15;

    auto result = sumCounts(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2913::sumCounts(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        std::vector present(101, false);
        int cur = 0;
        for (int j = i; j < n; ++j)
        {
            if (!present[nums[j]])
            {
                present[nums[j]] = true;
                cur++;
            }
            result += cur * cur;
        }
    }

    return result;
}
