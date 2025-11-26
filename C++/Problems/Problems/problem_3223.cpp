#include "problem_3223.h"

bool problem_3223::test() {
    std::string s = "abaacbcbb";

    int expected = 5;

    auto result = minimumLength(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3223::minimumLength(std::string s) {
    std::vector counts(26, 0);
    for (char c : s)
    {
        counts[c - 'a']++;
    }

    int result = 0;
    for (int count : counts)
    {
        if (count > 0)
            result += 1 + (count % 2 == 0 ? 1 : 0);
    }

    return result;
}
