#include "problem_1387.h"

#include <algorithm>

bool problem_1387::test() {
    int lo = 7;
    int hi = 11;
    int k = 4;

    int expected = 7;

    auto result = getKth(lo, hi, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1387::getKth(int lo, int hi, int k) {
    if (lo == hi)
        return lo;
    int n = hi - lo + 1;
    std::vector pows(3 * hi + 1, -1);
    pows[1] = 0;
    std::pair<int, int> forResult[n];
    for (int i = 0; i < n; ++i)
    {
        int num = i + lo;
        forResult[i] = std::pair(getPower(num, pows), num);
    }
    std::sort(forResult, forResult + n);

    return forResult[k - 1].second;
}

int problem_1387::getPower(int n, std::vector<int>& pows) {
    if (n < pows.size() && pows[n] != -1)
        return pows[n];

    return n % 2 == 0 ? getPower(n / 2, pows) + 1 : getPower(3 * n + 1, pows) + 1;
}
