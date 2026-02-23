#include "problem_1461.h"

#include <unordered_set>

bool problem_1461::test() {
    std::string s = "00110110";
    int k = 2;

    bool expected = true;

    auto result = hasAllCodes(s, k);

    return expected == result;
}

bool problem_1461::hasAllCodes(std::string s, int k) {
    int n = s.size();
    std::unordered_set<std::string> present;
    for (int i = 0; i <= n - k; ++i)
    {
        present.insert(s.substr(i, k));
    }

    return (1 << k) == present.size();
}
