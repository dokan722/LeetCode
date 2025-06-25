#include "problem_2040.h"

bool problem_2040::test() {
    std::vector nums1 {-4, -2, 0, 3};

    std::vector nums2 { 2, 4 };

    auto k = 6;

    auto expected = 0;

    auto result = kthSmallestProduct(nums1, nums2, k);

    return result == expected;
}

long long problem_2040::kthSmallestProduct(std::vector<int> &nums1, std::vector<int> &nums2, long long k) {
    auto l = nums1.size();
    auto left = -10000000000L;
    auto right = 10000000000L;
    while (left <= right)
    {
        long long mid = (left + right) / 2;
        long long count = 0;
        for (int i = 0; i < l; i++)
        {
            count += countSmaller(nums2, nums1[i], mid);
        }
        if (count < k)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return left;
}

int problem_2040::countSmaller(std::vector<int> &nums, long long f, long long v) {
    int l = nums.size();
    int left = 0;
    auto right = l - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        long long prod = (long long)nums[mid] * f;
        if ((f >= 0 && prod <= v) || (f < 0 && prod > v))
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    if (f >= 0)
    {
        return left;
    }
    return l - left;
}
