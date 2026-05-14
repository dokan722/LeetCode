#include "problem_3868.h"

#include <unordered_map>

bool problem_3868::test() {
    std::vector nums1 { 10, 20 };
    std::vector nums2 { 20, 10 };

    int expected = 0;

    auto result = minCost(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3868::minCost(std::vector<int> &nums1, std::vector<int> &nums2) {
    int n = nums1.size();
    std::unordered_map<int, int> counts;
    for (int i = 0; i < n; ++i)
    {
        if (counts.contains(nums1[i]))
            counts[nums1[i]]++;
        else
            counts[nums1[i]] = 1;
        if (counts.contains(nums2[i]))
            counts[nums2[i]]--;
        else
            counts[nums2[i]] = -1;
    }

    int result = 0;
    for (auto count : counts)
    {
        int val = std::abs(count.second);
        if (val % 2 != 0)
            return -1;
        result += val / 2;
    }

    return result / 2;
}
