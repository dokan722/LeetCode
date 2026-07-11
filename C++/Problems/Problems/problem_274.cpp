#include "problem_274.h"

bool problem_274::test() {
    std::vector citations { 3, 0, 6, 1, 5 };

    int expected = 3;

    auto result = hIndex(citations);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_274::hIndex(std::vector<int> &citations) {
    std::vector counts(1001, 0);
    for (auto c : citations)
        counts[c]++;
    int cur = 0;
    for (int i = 1000; i >= 0; --i)
    {
        cur += counts[i];
        if (cur >= i)
            return i;
    }

    return 0;
}
