#include "problem_3096.h"

bool problem_3096::test() {
    std::vector possible  { 1, 0, 1, 0 };

    int expected = 1;

    auto result = minimumLevels(possible);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3096::minimumLevels(std::vector<int> &possible) {
    int n = possible.size();
    int total = 0;
    for (auto p : possible)
        total += p == 0 ? -1 : 1;

    int alice = 0;
    for (int i = 0; i < n - 1; ++i)
    {
        alice += possible[i] == 0 ? -1 : 1;
        int bob = total - alice;
        if (bob < alice)
            return i + 1;
    }
    return -1;
}
