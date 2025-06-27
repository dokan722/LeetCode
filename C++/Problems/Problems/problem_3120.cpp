#include "problem_3120.h"

#include <unordered_map>

bool problem_3120::test() {
    auto word = "aaAbcBC";

    auto expected = 3;

    auto reslut = numberOfSpecialChars(word);

    return expected == reslut;
}

struct Case
{
    bool Lower;
    bool Upper;
};

int problem_3120::numberOfSpecialChars(std::string word) {
    std::unordered_map<int, Case> charDic;
    for (int i = 0; i < 26; ++i)
        charDic[i] = Case();

    for (auto c : word)
    {
        if (std::isupper(c))
            charDic[c - 'A'].Upper = true;
        else
            charDic[c - 'a'].Lower = true;
    }

    auto result = 0;
    for (auto &c : charDic)
        if (c.second.Upper && c.second.Lower)
            result++;

    return result;
}
