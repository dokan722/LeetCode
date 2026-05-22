#include "problem_1953.h"

bool problem_1953::test() {
    std::vector milestones { 1, 2, 3 };

    int expected = 6;

    auto result = numberOfWeeks(milestones);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_1953::numberOfWeeks(std::vector<int> &milestones) {
    long long sum = 0;
    int mx = 0;
    for (auto m : milestones)
    {
        sum += m;
        mx = std::max(mx, m);
    }

    return 2 * mx > sum ? 2 * (sum - mx) + 1 : sum;
}
