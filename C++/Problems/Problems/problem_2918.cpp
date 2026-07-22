#include "problem_2918.h"

bool problem_2918::test() {
    std::vector nums1 { 3, 2, 0, 1, 0 };
    std::vector nums2 { 6, 5, 0 };

    int expected = 12;

    auto result = minSum(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2918::minSum(std::vector<int> &nums1, std::vector<int> &nums2) {
    long long s1 = 0;
    long long s2 = 0;
    bool z1 = false;
    bool z2 = false;
    for (auto n : nums1)
    {
        if (n == 0)
        {
            s1++;
            z1 = true;
        }
        else
            s1 += n;
    }
    for (auto n : nums2)
    {
        if (n == 0)
        {
            s2++;
            z2 = true;
        }
        else
            s2 += n;
    }
    if ((s1 < s2 && !z1) || (s1 > s2 && !z2))
        return -1;
    return std::max(s1, s2);
}
