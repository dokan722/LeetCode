#include "problem_890.h"

#include <unordered_map>

bool problem_890::test() {
    std::vector<std::string> words { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
    std::string pattern = "abb";

    std::vector<std::string> expected { "mee", "aqq" };

    auto result = findAndReplacePattern(words, pattern);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_890::findAndReplacePattern(std::vector<std::string> &words, std::string pattern) {
    std::vector<std::string> result;
    auto ep = encode(pattern);
    for (auto word : words)
    {
        if (ep == encode(word))
            result.push_back(word);
    }

    return result;
}

std::string problem_890::encode(std::string word) {
    char num = '0';
    std::string result = "";
    std::unordered_map<char, char> map;
    for (auto c : word)
    {
        if (!map.contains(c))
        {
            map[c] = num;
            num++;
        }

        result += map[c];
    }

    return result;
}
