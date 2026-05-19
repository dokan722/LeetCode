#include "problem_2540.h"

bool problem_2540::test() {
    std::vector nums1  { 1, 2, 3 };
    std::vector nums2 { 2, 4 };

    int expected = 2;

    auto result = getCommon(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2540::getCommon(std::vector<int> &nums1, std::vector<int> &nums2) {
    int n1 = nums1.size();
    int n2 = nums2.size();
    int i1 = 0;
    int i2 = 0;
    while (i1 < n1 && i2 < n2)
    {
        if (nums1[i1] == nums2[i2])
            return nums1[i1];
        if (nums1[i1] < nums2[i2])
            i1++;
        else
            i2++;
    }

    return -1;
}
