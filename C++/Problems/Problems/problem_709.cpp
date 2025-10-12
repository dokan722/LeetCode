#include "problem_709.h"

#include <algorithm>

bool problem_709::test() {
    std::string s = "Hello";

    std::string expected = "hello";

    auto result = toLowerCase(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_709::toLowerCase(std::string s) {
    std::string result;
    for (auto c  : s)
        result += std::tolower(c);
    return result;
}
