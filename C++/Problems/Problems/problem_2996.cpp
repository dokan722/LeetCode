#include "problem_2996.h"

bool problem_2996::test() {
    std::vector nums  { 1, 2, 3, 2, 5 };

    int expected = 6;

    auto result = missingInteger(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2996::missingInteger(std::vector<int> &nums) {
    int n = nums.size();
    int s = nums[0];
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] != nums[i - 1] + 1)
            break;
        s += nums[i];
    }
    if (s > 50)
        return s;
    std::vector present(51, false);
    for (auto num : nums)
        present[num] = true;
    for (int i = s; i <= 50; ++i)
        if (!present[i])
            return i;
    return 51;
}
