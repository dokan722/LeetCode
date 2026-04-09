#include "problem_2678.h"

bool problem_2678::test() {
    std::vector<std::string> details { "7868190130M7522", "5303914400F9211", "9273338290F4010" };

    int expected = 2;

    auto result = countSeniors(details);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2678::countSeniors(std::vector<std::string> &details) {
    int result = 0;
    for (auto d : details)
        if (d[11] > '6' || (d[11] == '6' && d[12] > '0'))
            result++;
    return result;
}
