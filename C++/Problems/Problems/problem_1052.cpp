#include "problem_1052.h"

bool problem_1052::test() {
    std::vector customers { 1, 0, 1, 2, 1, 1, 7, 5 };
    std::vector grumpy { 0, 1, 0, 1, 0, 1, 0, 1 };
    int minutes = 3;

    int expected = 16;

    auto result = maxSatisfied(customers, grumpy, minutes);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1052::maxSatisfied(std::vector<int> &customers, std::vector<int> &grumpy, int minutes) {
    int n = customers.size();
    int satisfied = 0;
    int grumpies = 0;
    int best = 0;
    for (int i = 0; i < n; ++i)
    {
        if (grumpy[i] == 0)
            satisfied += customers[i];
        else
            grumpies += customers[i];
        if (i >= minutes && grumpy[i - minutes] == 1)
            grumpies -= customers[i - minutes];
        best = std::max(best, grumpies);
    }

    return satisfied + best;
}
