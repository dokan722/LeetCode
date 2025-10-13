#include "problem_2273.h"

#include <algorithm>

bool problem_2273::test() {
    std::vector<std::string> words { "abba", "baba", "bbaa", "cd", "cd" };

    std::vector<std::string> expected { "abba", "cd" };

    auto result = removeAnagrams(words);

    print1DVector(result);

    return result == expected;
}

std::vector<std::string> problem_2273::removeAnagrams(std::vector<std::string> &words) {
    std::vector<std::string> result  { words[0] };
    std::string current = words[0];
    std::sort(current.begin(), current.end());
    for (auto word : words)
    {
        std::string sorted = word;
        std::sort(sorted.begin(), sorted.end());
        if (sorted == current)
            continue;
        result.push_back(word);
        current = sorted;
    }


    return result;
}
