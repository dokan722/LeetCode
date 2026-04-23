#include "problem_3084.h"

bool problem_3084::test() {
    std::string s = "abada";
    char c = 'a';

    int expected = 6;

    auto result = countSubstrings(s, c);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3084::countSubstrings(std::string s, char c) {
    int count = 1;
    long result = 0;
    for (auto cr : s)
    {
        if (cr == c)
        {
            result += count;
            count++;
        }
    }

    return result;
}
