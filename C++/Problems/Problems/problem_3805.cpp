#include "problem_3805.h"

#include <unordered_map>

bool problem_3805::test() {
    std::vector<std::string> words { "ab", "aa", "za", "aa" };

    int expected = 2;

    auto result = countPairs(words);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3805::countPairs(std::vector<std::string> &words) {
    int m = words[0].size();
    long long result = 0;
    std::unordered_map<std::string, int> counts;
    for (auto w : words)
    {
        int b = w[0] - 'a';
        for (int i = 0; i < m; ++i)
            w[i] = (char)((w[i] - b + 26) % 26);
        if (counts.contains(w))
            result += counts[w]++;
        else
            counts[w] = 1;
    }
    return result;
}
