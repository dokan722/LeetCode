#include "problem_3477.h"

bool problem_3477::test() {
    std::vector fruits { 3, 6, 1 };
    std::vector baskets { 6, 4, 7 };

    auto expected = 0;

    auto result = numOfUnplacedFruits(fruits, baskets);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3477::numOfUnplacedFruits(std::vector<int> &fruits, std::vector<int> &baskets) {
    int n = fruits.size();
    auto result = 0;
    for (auto fruit : fruits)
    {
        auto bs = 0;
        while (bs < n && baskets[bs] < fruit)
            bs++;
        if (bs == n)
            continue;
        baskets[bs] = 0;
        result++;
    }

    return n - result;
}
