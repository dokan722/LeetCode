#include "problem_2357.h"

bool problem_2357::test() {
    std::vector nums  { 1, 5, 0, 3, 5 };

    int expected = 3;

    auto result = minimumOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2357::minimumOperations(std::vector<int> &nums) {
    int n = nums.size();
    std::vector present(101, false);
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (!present[nums[i]])
        {
            present[nums[i]] = true;
            result++;
        }
    }
    if (present[0])
        result--;
    return result;
}
