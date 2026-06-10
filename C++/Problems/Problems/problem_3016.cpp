#include "problem_3016.h"

bool problem_3016::test() {
    std::string word = "abcde";

    int expected = 5;

    auto result = minimumPushes(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3016::minimumPushes(std::string word) {
    std::vector<int> counts(26, 0);
    for (auto c : word)
        counts[c - 'a']++;
    std::sort(counts.begin(), counts.end());
    int result = 0;
    for (int i = 0; i < 26; ++i)
    {
        result += (i / 8 + 1) * counts[25 - i];
    }

    return result;
}
