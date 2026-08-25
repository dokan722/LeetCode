#include "problem_1872.h"

bool problem_1872::test() {
    std::vector stones { -1, 2, -3, 4, -5 };

    int expected = 5;

    auto result = stoneGameVIII(stones);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1872::stoneGameVIII(std::vector<int> &stones) {
    int n = stones.size();
    std::vector<int> pref(n);
    pref[0] = stones[0];
    for (int i = 1; i < n; ++i)
        pref[i] = pref[i - 1] + stones[i];
    int result = pref[n - 1];
    for (int i = n - 2; i > 0; --i)
        result = std::max(result, pref[i] - result);

    return result;
}
