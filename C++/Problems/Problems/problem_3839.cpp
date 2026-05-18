#include "problem_3839.h"

#include <unordered_map>

bool problem_3839::test() {
    std::vector<std::string> words { "apple", "apply", "banana", "bandit" };
    int k = 2;

    int expected = 2;

    auto result = prefixConnected(words, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3839::prefixConnected(std::vector<std::string> &words, int k) {
    int result = 0;
    std::unordered_map<std::string, int> groups;
    for (auto word : words)
    {
        if (word.size() < k)
            continue;
        auto pref = word.substr(0, k);
        if (groups.contains(pref))
        {
            if (groups[pref] == 1)
                result++;
            groups[pref]++;
        }
        else
            groups[pref] = 1;
    }

    return result;
}
