#include "problem_795.h"

bool problem_795::test() {
    std::vector nums  { 2, 9, 2, 5, 6 };
    auto left = 2;
    auto right = 8;

    auto expected = 7;

    auto result = numSubarrayBoundedMax(nums, left, right);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_795::numSubarrayBoundedMax(std::vector<int> &nums, int left, int right) {
    int n = nums.size();
    int count = 0;
    std::vector<int> properElements;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] <= right)
        {
            if (nums[i] >= left)
                properElements.push_back(i);
            count++;
        }
        else
        {
            if (!properElements.empty() && count > 0)
                result += getProperSubarrays(i, count, properElements);
            count = 0;
            properElements.clear();
        }
    }
    if (!properElements.empty() && count > 0)
        result += getProperSubarrays(n, count, properElements);


    return result;
}

int problem_795::getProperSubarrays(int index, int count, std::vector<int> properElements) {
    int start = index - count;
    int result = 0;
    for (auto properElement : properElements)
    {
        result += (properElement - start + 1) * (index - properElement);
        start = properElement + 1;
    }

    return result;
}
