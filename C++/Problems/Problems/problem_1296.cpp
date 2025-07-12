#include "problem_1296.h"

#include <map>

bool problem_1296::test() {
    std::vector nums { 3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11 };
    auto k = 3;

    auto expected = true;

    auto result = isPossibleDivide(nums, k);

    return expected == result;
}

bool problem_1296::isPossibleDivide(std::vector<int> &nums, int k) {
    int n = nums.size();
    if (n % k != 0)
        return false;
    std::map<int, int> freq;
    for (auto num : nums)
    {
        freq[num]++;
    }

    for (auto pair : freq)
    {
        int f = freq[pair.first];
        if (f == 0) continue;

        for (int i = 0; i < k; i++)
        {
            int next = pair.first + i;
            if (!freq.contains(next) || freq[next] < f)
                return false;
            freq[next] -= f;
        }
    }

    return true;
}
