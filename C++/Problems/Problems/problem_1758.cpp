#include "problem_1758.h"

bool problem_1758::test() {
    std::string s = "0100";

    int expected = 1;

    auto result = minOperations(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1758::minOperations(std::string s) {
    int count = 0;
    bool wantOne = true;
    for (auto c : s)
    {
        if (wantOne)
        {
            count += (c == '0' ? 1 : 0);
            wantOne = false;
        }
        else
        {
            count += (c == '0' ? 0 : 1);
            wantOne = true;
        }
    }

    return std::min(count, (int)s.size() - count);
}
