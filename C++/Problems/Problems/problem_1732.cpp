#include "problem_1732.h"

bool problem_1732::test() {
    std::vector gain { -5, 1, 5, 0, -7 };

    auto expected = 1;

    auto result = largestAltitude(gain);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1732::largestAltitude(std::vector<int> &gain) {
    auto att = 0;
    auto maxAtt = 0;
    for (auto i : gain)
    {
        att += i;
        if (att > maxAtt)
            maxAtt = att;
    }

    return maxAtt;
}
