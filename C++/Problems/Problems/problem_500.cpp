#include "problem_500.h"

#include <unordered_map>

bool problem_500::test() {
    std::vector<std::string> words { "Hello", "Alaska", "Dad", "Peace" };

    std::vector<std::string> expected { "Alaska", "Dad" };

    auto result = findWords(words);

    return result == expected;
}

std::vector<std::string> problem_500::findWords(std::vector<std::string> &words) {
    std::unordered_map<char, int> dic;
    for (auto c : "qwertyuiop")
        dic[c] = 0;
    for (auto c : "asdfghjkl")
        dic[c] = 1;
    for (auto c : "zxcvbnm")
        dic[c] = 2;
    std::vector<std::string> result
    ;

    for (auto word : words)
    {
        auto row = dic[std::tolower(word[0])];
        auto oneRow = true;
        for (auto c : word)
        {
            auto l = std::tolower(c);
            if (dic[l] != row)
            {
                oneRow = false;
                break;
            }
        }
        if (oneRow)
            result.push_back(word);
    }

    return result;
}
