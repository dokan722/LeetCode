#include "problem_2131.h"

bool problem_2131::test() {
    std::vector<std::string> words  { "lc", "cl", "gg" };

    int expected = 6;

    auto result = longestPalindrome(words);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2131::longestPalindrome(std::vector<std::string> &words) {
    std::vector pairs(26, std::vector(26, 0));
    for (auto word : words)
    {
        pairs[word[0] - 'a'][word[1] - 'a']++;
    }

    int sidePairs = 0;
    bool anyOdd = false;
    for (int i = 0; i < 26; ++i)
    {
        anyOdd = anyOdd || (pairs[i][i] % 2 == 1);
        sidePairs += pairs[i][i] / 2;
        for (int j = i + 1; j < 26; ++j)
        {
            sidePairs += std::min(pairs[i][j], pairs[j][i]);
        }
    }

    return sidePairs * 4 + (anyOdd ? 2 : 0);
}
