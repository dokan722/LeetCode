#include "problem_80.h"

bool problem_80::test() {
    std::vector nums  { 1, 1, 1, 2, 2, 3 };

    int expected = 5;

    auto result = removeDuplicates(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_80::removeDuplicates(std::vector<int> &nums) {
    int cur = 0;
    int cnt = 0;
    int prev = nums[0];
    for (int i = 0; i < nums.size(); ++i)
    {
        if (nums[i] == prev)
            cnt++;
        else
        {
            prev = nums[i];
            cnt = 1;
        }
        if (cnt <= 2)
        {
            nums[cur] = nums[i];
            cur++;
        }
    }

    return cur;
}
