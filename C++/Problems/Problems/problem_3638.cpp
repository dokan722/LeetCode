#include "problem_3638.h"

bool problem_3638::test() {
    std::vector weight  { 2, 5, 1, 4, 3 };

    int expected = 2;

    auto result = maxBalancedShipments(weight);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3638::maxBalancedShipments(std::vector<int> &weight) {
    int result = 0;
    int m = 0;
    for (auto w : weight)
    {
        m = std::max(m, w);
        if (w < m)
        {
            result++;
            m = 0;
        }
    }
    return result;
}
