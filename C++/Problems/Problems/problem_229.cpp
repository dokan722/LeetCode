#include "problem_229.h"

#include <unordered_set>

bool problem_229::test() {
    std::vector nums { 2, 2 };

    std::vector expected { 2 };

    auto result = majorityElement(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_229::majorityElement(std::vector<int> &nums) {
    int n = nums.size();
    int k = 2;
    if (k >= n) {
        std::unordered_set<int> elems(nums.begin(), nums.end());
        return std::vector(elems.begin(), elems.end());
    }
    std::vector cands(k, INT_MIN);
    std::vector counts(k, 0);
    for (int i = 0; i < n; ++i)
    {
        bool present = false;
        for (int j = 0; j < k; ++j)
        {
            if (nums[i] == cands[j])
            {
                counts[j]++;
                present = true;
                break;
            }
        }
        bool replaced = present;
        if (!present)
        {
            for (int j = 0; j < k; ++j)
            {
                if (counts[j] == 0)
                {
                    cands[j] = nums[i];
                    replaced = true;
                    counts[j] = 1;
                    break;
                }
            }
        }
        if (!replaced)
        {
            for (int j = 0; j < k; ++j)
                counts[j]--;
        }
    }
    std::vector<int> result;
    for (int i = 0; i < k; ++i)
        counts[i] = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < k; ++j)
        {
            if (cands[i] != INT_MIN && cands[j] == nums[i])
                counts[j]++;
        }
    }
    for (int i = 0; i < k; ++i)
    {
        if (counts[i] > n / 3)
            result.push_back(cands[i]);
    }

    return result;
}
