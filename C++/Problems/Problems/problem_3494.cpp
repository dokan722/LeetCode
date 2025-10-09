#include "problem_3494.h"

bool problem_3494::test() {
    std::vector skill { 1, 5, 2, 4 };
    std::vector mana { 5, 1, 4, 2 };

    int expected = 110;

    auto result = minTime(skill, mana);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_3494::minTime(std::vector<int> &skill, std::vector<int> &mana) {
    int n = skill.size();
    int m = mana.size();
    std::vector<long long> times(n + 1, 0);
    for (int i = 0; i < m; ++i)
    {
        for (int j = 1; j <= n; j++)
            times[j] = std::max(times[j], times[j - 1]) + (long long)mana[i] * skill[j - 1];

        for (int j = n - 1; j >= 0; j--)
            times[j] = times[j + 1] - (long long)mana[i] * skill[j];
    }
    return times[n];
}
