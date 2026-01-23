#include "problem_2537.h"

#include <unordered_map>

bool problem_2537::test() {
    std::vector nums { 3, 1, 4, 3, 2, 2, 4 };
    int k = 2;

    int expected = 4;

    auto result = countGood(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_2537::countGood(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::unordered_map<int, int> counts;
    int l = 0;
    int r = -1;
    int p = 0;
    long long result = 0;
    while (r < n - 1)
    {
        while (p < k && r < n - 1)
        {
            r++;
            if (!counts.contains(nums[r]))
                counts[nums[r]] = 0;
            p += counts[nums[r]];
            counts[nums[r]]++;
        }
        while (p >= k)
        {
            result += n - r;
            counts[nums[l]]--;
            p -= counts[nums[l]];
            l++;
        }
    }

    return result;
}
