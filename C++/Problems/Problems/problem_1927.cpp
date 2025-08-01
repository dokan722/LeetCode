#include "problem_1927.h"

bool problem_1927::test() {
    std::string num = "?3295???";

    auto expected = false;

    auto result = sumGame(num);

    return result == expected;
}

bool problem_1927::sumGame(std::string num) {
    int n = num.size();
    auto q1 = 0;
    auto q2 = 0;
    auto sum1 = 0;
    auto sum2 = 0;
    for (int i = 0; i < n / 2; ++i)
    {
        if (num[i] == '?')
            q1++;
        else
            sum1 += num[i] - '0';
    }
    for (int i = n / 2; i < n; ++i)
    {
        if (num[i] == '?')
            q2++;
        else
            sum2 += num[i] - '0';
    }



    if ((q1 + q2) % 2 == 0 && 2 * (sum1 - sum2) == (q2 - q1) * 9)
        return false;

    return true;
}
