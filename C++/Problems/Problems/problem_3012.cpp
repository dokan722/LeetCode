#include "problem_3012.h"

bool problem_3012::test() {
    std::vector nums { 1, 4, 3, 1 };

    int expected = 1;

    auto result = minimumArrayLength(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3012::minimumArrayLength(std::vector<int> &nums) {
    int mn = INT_MAX;
    for (auto num : nums)
        mn = std::min(mn, num);
    for (auto num : nums)
        if (num % mn > 0)
            return 1;
    int cnt = 0;
    for (auto num : nums)
        if (num == mn)
            cnt++;
    return (cnt + 1) / 2;
}
