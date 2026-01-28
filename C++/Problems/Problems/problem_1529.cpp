#include "problem_1529.h"

bool problem_1529::test() {
    std::string target = "10111";

    int expected = 3;

    auto result = minFlips(target);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1529::minFlips(std::string target) {
    bool waitingZero = false;
    int count = 0;
    for (auto c : target)
    {
        if (c == '1')
            waitingZero = true;
        else
        {
            if (waitingZero)
                count++;
            waitingZero = false;
        }
    }

    return 2 * count + (waitingZero ? 1 : 0);
}
