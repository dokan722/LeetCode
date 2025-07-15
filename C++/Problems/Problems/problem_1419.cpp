#include "problem_1419.h"

#include <unordered_map>

bool problem_1419::test() {
    std::string croakOfFrogs = "crcoakroak";

    auto expected = 2;

    auto result = minNumberOfFrogs(croakOfFrogs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1419::minNumberOfFrogs(std::string croakOfFrogs) {
    std::string croak = "croak";
    std::unordered_map<char, int> ids { { 'c', 0 }, { 'r', 1 }, { 'o', 2 }, { 'a', 3 }, { 'k', 4 } };
    std::vector counts(5, 0);
    auto maxFrogs = 0;
    for (auto c : croakOfFrogs)
    {
        counts[ids[c]]++;
        if (c != 'c' && counts[ids[c]] > counts[ids[c] - 1])
            return -1;
        if (c == 'k')
        {
            auto frogsNow = counts[0] - counts[4] + 1;
            if (frogsNow > maxFrogs)
                maxFrogs = frogsNow;
        }
    }
    auto expectedCount = counts[0];
    for (int i = 1; i < 5; ++i)
        if (counts[i] != expectedCount)
            return -1;

    return maxFrogs;
}
