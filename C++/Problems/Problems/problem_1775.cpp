#include "problem_1775.h"

#include <cmath>

bool problem_1775::test() {
    std::vector nums1 { 1, 2, 3, 4, 5, 6 };
    std::vector nums2 { 1, 1, 2, 2, 2, 2 };

    auto expected = 3;

    auto result = minOperations(nums1, nums2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1775::minOperations(std::vector<int> &nums1, std::vector<int> &nums2) {
    std::vector ns { nums1.size(), nums2.size() };
    std::vector sums { 0, 0 };
    std::vector counts { std::vector<int>(7), std::vector<int>(7) };
    for (int i = 0; i < ns[0]; ++i)
    {
        sums[0] += nums1[i];
        counts[0][nums1[i]]++;
    }
    for (int i = 0; i < ns[1]; ++i)
    {
        sums[1] += nums2[i];
        counts[1][nums2[i]]++;
    }

    auto longer = ns[0] > ns[1] ? 0 : 1;
    auto shorter = (longer + 1) % 2;
    auto bigger = sums[0] > sums[1] ? 0 : 1;
    auto smaller = (bigger + 1) % 2;

    if (ns[longer] > ns[shorter] * 6)
        return -1;


    auto ops = 0;
    for (int i = 1; i < 6; ++i)
    {
        auto diff = sums[bigger] - sums[smaller];
        auto currentChange = 6 - i;
        if ((counts[smaller][i] + counts[bigger][7 - i]) * currentChange >= diff)
        {
            ops += std::ceil((double)diff / currentChange);
            break;
        }

        ops += counts[smaller][i];
        ops += counts[bigger][7 - i];
        sums[smaller] += counts[smaller][i] * currentChange;
        sums[bigger] -= counts[bigger][7 - i] * currentChange;

    }

    return ops;
}
