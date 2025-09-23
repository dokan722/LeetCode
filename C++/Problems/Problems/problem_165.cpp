#include "problem_165.h"

#include <sstream>

bool problem_165::test() {
    std::string version1 = "1.2";
    std::string version2 = "1.10";

    int expected = -1;

    auto result = compareVersion(version1, version2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_165::compareVersion(std::string version1, std::string version2) {
    std::vector splitted{ splitToInts(version1), splitToInts(version2) };
    int longer = splitted[0].size() > splitted[1].size() ? 0 : 1;
    int shorter = (longer + 1) % 2;
    for (int i = 0; i < splitted[shorter].size(); ++i)
    {
        if (splitted[0][i] > splitted[1][i])
            return 1;
        if (splitted[0][i] < splitted[1][i])
            return -1;
    }
    for (int i = splitted[shorter].size(); i < splitted[longer].size(); ++i)
    {
        if (splitted[longer][i] != 0)
            return longer == 1 ? -1 : 1;
    }

    return 0;
}

std::vector<int> problem_165::splitToInts(const std::string &s) {
    std::vector<int> result;
    std::stringstream ss(s);
    std::string part;

    while (std::getline(ss, part, '.')) {
        result.push_back(std::stoi(part));
    }

    return result;
}
