#include "problem_3724.h"

bool problem_3724::test() {
    std::vector nums1 {2, 8};
    std::vector nums2 { 1, 7, 3 };

    int expected = 4;

    auto result = minOperations(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3724::minOperations(std::vector<int> &nums1, std::vector<int> &nums2) {
    int n = nums1.size();
    long long result = 0;
    int last = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        result += std::abs(nums1[i] - nums2[i]);
        if (std::min(nums1[i], nums2[i]) <= nums2[n] && nums2[n] <= std::max(nums1[i], nums2[i]))
            last = 0;
        else
            last = std::min(last, std::min(std::abs(nums1[i] - nums2[n]), std::abs(nums2[i] - nums2[n])));
    }

    return result + last + 1;
}
