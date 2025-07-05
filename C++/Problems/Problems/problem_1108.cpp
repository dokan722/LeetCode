#include "problem_1108.h"

#include <sstream>

bool problem_1108::test() {
    std::string address = "1.1.1.1";

    std::string expected = "1[.]1[.]1[.]1";

    auto result = defangIPaddr(address);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1108::defangIPaddr(std::string address) {
    std::ostringstream result;
    for (auto c : address) {
        if (c != '.')
            result << c;
        else
            result << "[.]";
    }
    return result.str();
}
