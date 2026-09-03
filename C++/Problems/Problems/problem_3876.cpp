#include "problem_3876.h"

bool problem_3876::test() {
    std::vector nums1 { 1, 4, 7 };

    bool expected = true;

    auto result = uniformArray(nums1);

    return result == expected;
}

bool problem_3876::uniformArray(std::vector<int> &nums1) {
    int mn = nums1[0];
    bool odd = false;
    for (auto n : nums1)
    {
        mn = std::min(mn, n);
        if (n % 2 == 1)
            odd = true;
    }
    if (mn % 2 == 1)
        return true;
    return !odd;
}
