#include "problem_3330.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_3330::test() {
    std::string word = "abbcccc";

    auto expected = 5;

    auto result = possibleStringCount(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3330::possibleStringCount(std::string word) {
    auto len = 1;
    auto prev = word[0];
    auto result = 1;
    for (int i = 1; i < word.size(); i++)
    {
        if (prev != word[i])
        {
            result += (len - 1);
            len = 1;
            prev = word[i];
        }
        else
            len++;
    }

    result += (len - 1);

    return result;
}
