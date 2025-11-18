#include "problem_717.h"

bool problem_717::test() {
    std::vector bits { 1, 1, 1, 0 };

    bool expected = false;

    auto result = isOneBitCharacter(bits);

    return result == expected;
}

bool problem_717::isOneBitCharacter(std::vector<int> &bits) {
    int n = bits.size();
    for (int i = 0; i < n; ++i)
    {
        if (bits[i] == 1)
        {
            if (i == n - 2)
                return false;
            i++;
        }
        else
        {
            if (i == n - 1)
                return true;
        }
    }

    return true;
}
