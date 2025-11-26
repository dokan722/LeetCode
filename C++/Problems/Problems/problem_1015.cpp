#include "problem_1015.h"

#include <unordered_set>

bool problem_1015::test() {
    int k = 3;

    int expected = 3;

    auto result = smallestRepunitDivByK(k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1015::smallestRepunitDivByK(int k) {
    int num = 1;
    std::unordered_set<int> seen;
    for (int i = 0; i <= k; ++i)
    {
        num %= k;
        if (num == 0)
            return i + 1;
        seen.insert(num);
        num = num * 10 + 1;
    }

    return -1;
}
