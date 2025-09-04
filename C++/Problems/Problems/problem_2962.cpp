#include "problem_2962.h"

#include <algorithm>

bool problem_2962::test() {
    std::vector nums { 1, 3, 2, 3, 3 };
    int k = 2;

    int expected = 6;

    int result = countSubarrays(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2962::countSubarrays(std::vector<int> &nums, int k) {
    int n = nums.size();
    int max = *std::max_element(nums.begin(), nums.end());
    int count = 0;
    long long result = 0;
    int j = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == max)
            count++;
        while (j < n && count >= k)
        {
            result += n - i;
            if (nums[j] == max)
                count--;
            j++;
        }
    }

    return result;
}
