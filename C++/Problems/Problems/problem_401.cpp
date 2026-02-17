#include "problem_401.h"

#include <format>

bool problem_401::test() {
    int turnedOn = 9;

    std::vector<std::string> expected { };

    auto result = readBinaryWatch(turnedOn);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_401::readBinaryWatch(int turnedOn) {
    std::vector<std::string> result;
    std::vector values  { 8, 4, 2, 1, 32, 16, 8, 4, 2, 1 };
    watchRec(0, turnedOn, 0, 0, 0, values, result);
    return result;
}

void problem_401::watchRec(int curr, int limit, int start, int minutes, int hours, std::vector<int>& values, std::vector<std::string>& result) {
    if (minutes > 59 || hours > 11 || 10 - start < limit - curr)
        return;
    if (curr == limit)
    {
        result.push_back(std::to_string(hours) + ":" + std::format("{:02}", minutes));
        return;
    }
    for (int i = start; i < 4; ++i)
        watchRec(curr + 1, limit, i + 1, minutes, hours + values[i], values, result);
    for (int i = std::max(start, 4); i < 10; ++i)
        watchRec(curr + 1, limit, i + 1, minutes + values[i], hours, values, result);
}
