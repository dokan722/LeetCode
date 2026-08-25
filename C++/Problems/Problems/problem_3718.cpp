#include "problem_3718.h"

bool problem_3718::test() {
    std::vector nums { 8, 2, 3, 4, 6 };
    int k = 2;

    int expected = 10;

    auto result = missingMultiple(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3718::missingMultiple(std::vector<int> &nums, int k) {
    int mx = (100 + k) / k;
    std::vector present(mx, false);
    for (auto n : nums)
        if (n % k == 0)
            present[n / k] = true;
    for (int i = 1; i < mx; ++i)
        if (!present[i])
            return i * k;
    return mx * k;
}
