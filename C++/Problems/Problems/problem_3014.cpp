#include "problem_3014.h"

bool problem_3014::test() {
    std::string word = "abcde";

    int expected = 5;

    auto result = minimumPushes(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3014::minimumPushes(std::string word) {
    std::vector counts(26, 0);
    for (auto c : word)
        counts[c - 'a']++;
    std::sort(counts.begin(), counts.end());
    int result = 0;
    for (int i = 0; i < 26; ++i)
    {
        int times = (i + 8) / 8;
        result += times * counts[25 - i];
    }

    return result;
}
