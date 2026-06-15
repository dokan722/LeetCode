#include "problem_2706.h"

bool problem_2706::test() {
    std::vector prices { 1, 2, 2 };
    int money = 3;

    int expected = 0;

    auto result = buyChoco(prices, money);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2706::buyChoco(std::vector<int> &prices, int money) {
    int m = INT_MAX;
    int mm = INT_MAX;
    for (auto p : prices)
    {
        if (p <= m)
        {
            mm = m;
            m = p;
        }
        else if (p < mm)
            mm = p;
    }

    int rest = money - m - mm;
    return rest >= 0 ? rest : money;
}
