#include "problem_2012.h"

bool problem_2012::test() {
    std::vector nums { 1, 2, 3 };

    int expected = 2;

    auto result = sumOfBeauties(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2012::sumOfBeauties(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    int mx = nums[0];
    std::vector<int> mins(n);
    mins[n - 1] = nums[n - 1];
    for (int i = n - 2; i >= 0; --i)
    {
        mins[i] = std::min(mins[i + 1], nums[i]);
    }
    for (int i = 1; i < n - 1; ++i)
    {
        if (nums[i] > mx && nums[i] < mins[i + 1])
            result += 2;
        else if (nums[i] > nums[i - 1] && nums[i] < nums[i + 1])
            result += 1;
        mx = std::max(mx, nums[i]);
    }
    return result;
}
