#include "problem_2216.h"

bool problem_2216::test() {
    std::vector nums { 1, 1, 2, 3, 5 };

    int expected = 1;

    auto result = minDeletion(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2216::minDeletion(std::vector<int> &nums) {
    int n = nums.size();
    if (n == 1)
        return 1;
    int result = 0;
    int i = 0;
    int j = 1;
    while (j < n)
    {
        if (nums[i] == nums[j])
        {
            result++;
            j++;
        }
        else
        {
            i = j + 1;
            j += 2;
        }
    }
    if ((n - result) % 2 != 0)
        result++;
    return result;
}
