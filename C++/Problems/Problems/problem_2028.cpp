#include "problem_2028.h"

bool problem_2028::test() {
    std::vector rolls { 3, 2, 4, 3 };
    int mean = 4;
    int n = 2;

    std::vector expected { 6, 6 };

    auto result = missingRolls(rolls, mean, n);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2028::missingRolls(std::vector<int> &rolls, int mean, int n) {
    int m = rolls.size();
    int req = (n + m) * mean;
    for (auto r : rolls)
        req -= r;
    req -= n;
    if (req < 0)
        return {};
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
    {
        if (req <= 0)
            result[i] = 1;
        else
        {
            int big = std::min(req, 5);
            result[i] = big + 1;
            req -= big;
        }
    }

    return req <= 0 ? result : std::vector<int>();
}
