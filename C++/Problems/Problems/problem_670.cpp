#include "problem_670.h"

bool problem_670::test() {
    int num = 2736;

    int expected = 7236;

    auto result = maximumSwap(num);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_670::maximumSwap(int num) {
    auto s = std::to_string(num);
    int n = s.size();
    for (int i = 0; i < n; ++i)
    {
        int mx = i;
        for (int j = i + 1; j < n; ++j)
            if (s[j] > s[i] && s[j] >= s[mx])
                mx = j;
        if (i != mx)
            return std::stoi(s.substr(0, i) + s[mx] + s.substr(i + 1, mx - i - 1) + s[i] + s.substr(mx + 1));
    }

    return num;
}
