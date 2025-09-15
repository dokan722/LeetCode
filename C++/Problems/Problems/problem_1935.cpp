#include "problem_1935.h"

#include <unordered_set>

bool problem_1935::test() {
    std::string text = "hello world";
    std::string brokenLetters = "ad";

    int expected = 1;

    int result = canBeTypedWords(text, brokenLetters);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1935::canBeTypedWords(std::string text, std::string brokenLetters) {
    std::unordered_set<char> lettersSet;
    for (auto letter : brokenLetters)
        lettersSet.insert(letter);

    int words = 1;
    int brokenWords = 0;
    bool canWrite = true;
    for (auto c : text)
    {
        if (c == ' ')
        {
            words++;
            canWrite = true;
            continue;
        }

        if (canWrite && lettersSet.contains(c))
        {
            brokenWords++;
            canWrite = false;
        }
    }
    return words - brokenWords;
}
