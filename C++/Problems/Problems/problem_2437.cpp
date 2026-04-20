#include "problem_2437.h"

bool problem_3437::test() {
    std::string time = "?5:00";

    int expected = 2;

    auto result = countTime(time);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3437::countTime(std::string time) {
    int result = 1;
    if (time[0] == '?')
    {
        if (time[1] == '?')
            result *= 24;
        else
        {
            if (time[1] < '4')
                result *= 3;
            else
                result *= 2;
        }
    }
    else
    {
        if (time[1] == '?')
        {
            if (time[0] == '2')
                result *= 4;
            else
                result *= 10;
        }
    }
    if (time[3] == '?')
        result *= 6;
    if (time[4] == '?')
        result *= 10;

    return result;
}
