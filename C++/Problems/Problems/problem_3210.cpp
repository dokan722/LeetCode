#include "problem_3210.h"

bool problem_3210::test() {
    std::string s = "dart";
    int k = 3;

    std::string expected = "tdar";

    auto result = getEncryptedString(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3210::getEncryptedString(std::string s, int k) {
    int n = s.size();
    int shift = (k % n);
    return s.substr(shift) + s.substr(0, shift);
}
