#include "problem_2554.h"

#include <unordered_set>

bool problem_2554::test() {
    std::vector banned { 1, 6, 5 };
    int n = 5;
    int maxSum = 6;

    int expected = 2;

    auto result = maxCount(banned, n, maxSum);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2554::maxCount(std::vector<int> &banned, int n, int maxSum) {
    int result = 0;
    int cSum = 0;
    std::unordered_set<int> bannedSet(banned.begin(), banned.end());
    for (int i = 1; i <= n; ++i)
    {
        if (cSum + i > maxSum)
            break;
        if (bannedSet.contains(i))
            continue;

        cSum += i;
        result++;
    }

    return result;
}
