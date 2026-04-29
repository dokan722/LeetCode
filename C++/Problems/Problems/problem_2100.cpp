#include "problem_2100.h"

bool problem_2100::test() {
    std::vector security { 5, 3, 3, 3, 5, 6, 2 };
    int time = 2;

    std::vector expected { 3, 2 };

    auto result = goodDaysToRobBank(security, time);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2100::goodDaysToRobBank(std::vector<int> &security, int time) {
    int n = security.size();
    std::vector<int> before(n);
    before[0] = 0;
    for (int i = 1; i < n; ++i)
    {
        if (security[i - 1] >= security[i])
            before[i] = before[i - 1] + 1;
        else
            before[i] = 0;
    }
    int after = 0;
    std::vector<int> result;
    for (int i = n - 2; i > 0; --i)
    {
        if (security[i + 1] >= security[i])
            after++;
        else
            after = 0;
        if (before[i] >= time && after >= time)
            result.push_back(i);
    }

    return result;
}
