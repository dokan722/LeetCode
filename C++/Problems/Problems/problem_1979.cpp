#include "problem_1979.h"

bool problem_1979::test() {
    std::vector nums { 2, 5, 6, 9, 10 };

    int expected = 2;

    auto result = findGCD(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1979::findGCD(std::vector<int> &nums) {
    int mx = 0;
    int mn = 1001;
    for (auto num : nums)
    {
        mn = std::min(mn, num);
        mx = std::max(mx, num);
    }

    while (mn != 0)
    {
        mx %= mn;
        std::swap(mx, mn);
    }

    return mx;
}
