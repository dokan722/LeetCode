#include "problem_2090.h"

bool problem_2090::test() {
    std::vector nums { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
    int k = 3;

    std::vector expected { -1, -1, -1, 5, 4, 4, -1, -1, -1 };

    auto result = getAverages(nums, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2090::getAverages(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector<int> result(n);
    long long s = 0;
    long long sl = 2 * k + 1;
    for (int i = 0; i < n + k; ++i)
    {
        if (i < n)
            s += nums[i];
        if (i >= sl)
            s -= nums[i - sl];
        if (i >= sl - 1 && i < n)
            result[i - k] = (int)(s / sl);
        else if (i >= k)
            result[i - k] = -1;
    }
    return result;
}
