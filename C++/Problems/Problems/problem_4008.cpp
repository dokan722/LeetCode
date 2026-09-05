#include "problem_4008.h"

bool problem_4008::test() {
    std::vector monsters { 5, 10, 15 };
    std::vector<std::vector<int>> boosts { { 1, 1, 10 } };

    int expected = 30;;

    auto result = minInitialStrength(monsters, boosts);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_4008::minInitialStrength(std::vector<int> &monsters, std::vector<std::vector<int>> &boosts) {
    int n = monsters.size();
    std::vector<long long> sweep(n + 1);
    for (auto boost : boosts)
    {
        sweep[boost[0]] += boost[2];
        sweep[boost[1] + 1] -= boost[2];
    }
    long long result = 0;
    long long curb = 0;
    long long acc = 0;
    for (int i = 0; i < n; ++i)
    {
        curb += sweep[i];
        if (curb < monsters[i])
        {
            result += acc + monsters[i] - curb;
            acc = curb;
        }
        else
            acc += monsters[i];
    }
    return result;
}
