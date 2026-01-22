#include "problem_3675.h"

bool problem_3675::test() {
    std::string s = "yz";

    int expected = 2;

    auto result = minOperations(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3675::minOperations(std::string s) {
    std::vector present(26, false);
    for (auto c : s)
    {
        present[c - 'a'] = true;
    }
    int prev = -1;
    int result = 0;
    for (int i = 1; i < 26; ++i)
    {
        if (present[i])
        {
            if (prev == -1)
                prev = i;
            else
            {
                result += i - prev;
                prev = i;
            }
        }
    }

    return result + (prev != -1 ? 26 - prev : 0);
}
