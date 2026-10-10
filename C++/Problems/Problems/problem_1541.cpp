#include "problem_1541.h"

bool problem_1541::test() {
    std::string s = "(()))";

    int expected = 1;

    auto result = minInsertions(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1541::minInsertions(std::string s) {
    int n = s.size();
    int d = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '(')
            d++;
        if (s[i] == ')')
        {
            if (i < n - 1 && s[i + 1] == ')')
                i++;
            else
                result++;
            if (d == 0)
                result++;
            else
                d--;
        }
    }
    return result + 2 * d;
}
