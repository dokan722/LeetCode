#include "problem_3075.h"

#include <algorithm>

bool problem_3075::test() {
    std::vector happiness { 1, 2, 3 };
    int k = 2;

    int expected = 4;

    auto result = maximumHappinessSum(happiness, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3075::maximumHappinessSum(std::vector<int> &happiness, int k) {
    int n = happiness.size();
    std::sort(happiness.begin(), happiness.end());

    long long result = 0;
    for (int i = 0; i < k; ++i)
    {
        result += std::max(0, happiness[n - i - 1] - i);
    }

    return result;
}
