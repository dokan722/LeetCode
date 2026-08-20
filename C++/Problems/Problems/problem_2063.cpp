#include "problem_2063.h"

bool problem_2063::test() {
    std::string word = "aba";

    int expected = 6;

    auto result = countVowels(word);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2063::countVowels(std::string word) {
    int n = word.size();
    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        char c = word[i];
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            long before = i + 1;
            long after = n - i;
            result += before * after;
        }
    }

    return result;
}
