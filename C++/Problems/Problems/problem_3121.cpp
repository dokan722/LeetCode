#include "problem_3121.h"

bool problem_3121::test() {
    std::string word = "aaAbcBC";

    int expected = 3;

    auto result = numberOfSpecialChars(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3121::numberOfSpecialChars(std::string word) {
    int n = word.size();
    std::vector lowers(26, 0);
    std::vector uppers(26, 0);
    for (int i = 0; i < n; ++i)
    {
        int upper = word[i] <= 'Z';
        int id = upper ? word[i] - 'A' : word[i] - 'a';
        if (upper)
        {
            if (uppers[id] == 0)
                uppers[id] = i + 1;
        }
        else
            lowers[id] = i + 1;
    }
    int result = 0;
    for (int i = 0; i < 26; ++i)
    {
        if (lowers[i] > 0 && uppers[i] > lowers[i])
            result++;
    }
    return result;
}
