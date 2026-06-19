#include "problem_1904.h"

bool problem_1904::test() {
    std::string loginTime = "09:31";
    std::string logoutTime = "10:14";

    int expected = 1;

    auto result = numberOfRounds(loginTime, logoutTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1904::numberOfRounds(std::string loginTime, std::string logoutTime) {
    int inTs = std::stoi(loginTime.substr(0, 2)) * 60 + std::stoi(loginTime.substr(3, 2));
    int outTs = std::stoi(logoutTime.substr(0, 2)) * 60 + std::stoi(logoutTime.substr(3, 2));
    int first = (inTs + 14) / 15;
    int last = outTs / 15;
    if (inTs < outTs && first > last)
        return 0;

    return first <= last ? last - first : (4 * 24) - first + last;
}
