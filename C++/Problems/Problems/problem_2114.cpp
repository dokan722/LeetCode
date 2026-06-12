#include "problem_2114.h"

bool problem_2114::test() {
    std::vector<std::string> sentences { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

    int expected = 6;

    auto result = mostWordsFound(sentences);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2114::mostWordsFound(std::vector<std::string> &sentences) {
    int result = 0;
    for (auto s : sentences)
    {
        int cur = 1;
        for (auto c : s)
            if (c == ' ')
                cur++;
        result = std::max(result, cur);
    }
    return result;
}
