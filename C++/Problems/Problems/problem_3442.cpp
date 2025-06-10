#include "problem_3442.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_3442::test() {
    auto n = "aaaaabbc";

    auto expected = 3;

    auto result = maxDifference(n);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3442::maxDifference(std::string s) {
    int charDic[26];
    for (int i = 0; i < 26; ++i)
    {
        charDic[i] = 0;
    }
    for (char c : s)
    {
        charDic[c - 'a']++;
    }

    auto min = INT_MAX;
    auto max = 0;
    for (auto count : charDic)
    {
        if (count == 0)
            continue;
        if (count % 2 == 1 && count > max)
            max = count;
        else if (count % 2 == 0 && count < min)
            min = count;
    }


    return max - min;
}
