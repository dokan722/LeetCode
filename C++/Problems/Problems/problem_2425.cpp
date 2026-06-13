#include "problem_2425.h"

bool problem_2425::test() {
    std::vector nums1 { 2, 1, 3 };
    std::vector nums2 { 10, 2, 5, 0 };

    int expected = 13;

    auto result = xorAllNums(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2425::xorAllNums(std::vector<int> &nums1, std::vector<int> &nums2) {
    int result = 0;
    int n = nums1.size();
    int m = nums2.size();
    if (n % 2 == 1)
    {
        for (auto num : nums2)
            result ^= num;
    }
    if (m % 2 == 1)
    {
        for (auto num : nums1)
            result ^= num;
    }

    return result;
}
