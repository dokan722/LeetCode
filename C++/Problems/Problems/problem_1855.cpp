#include "problem_1855.h"

#include <iostream>
#include <ostream>

bool problem_1855::test() {
    std::vector nums1  { 55, 30, 5, 4, 2 };

    std::vector nums2  { 100, 20, 10, 10, 5 };

    auto expected = 2;

    auto result = maxDistance(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1855::maxDistance(std::vector<int>& nums1, std::vector<int>& nums2) {
    int i = 0;
    int j = 0;

    auto result = 0;

    while (i < nums1.size() && j < nums2.size())
    {
        if (i <= j && nums1[i] <= nums2[j])
        {
            auto dist = j - i;
            if (dist > result)
                result = dist;
            j++;
        }
        else if (i > j)
            j++;
        else
            i++;
    }

    return result;
}
