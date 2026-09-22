#include "problem_3524.h"

bool problem_3524::test() {
    std::vector nums { 1, 2, 3, 4, 5 };
    int k = 3;

    std::vector<long long> expected { 9, 2, 4 };

    auto result = resultArray(nums, k);

    print1DVector(result);

    return expected == result;
}

std::vector<long long> problem_3524::resultArray(std::vector<int> &nums, int k) {
    std::vector<long long> result(k, 0);
    std::vector<long long> prev(k , 0);
    for (auto num : nums)
    {
        int rem = num % k;
        std::vector<long long> next(k, 0);
        for (int i = 0; i < k; ++i)
        {
            next[(i * rem) % k] += prev[i];
        }
        next[rem]++;
        for (int i = 0; i < k; ++i)
        {
            result[i] += next[i];
        }
        prev = next;
    }

    return result;
}
