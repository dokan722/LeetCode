#include "problem_1525.h"

#include <unordered_map>

bool problem_1525::test() {
    std::string s = "aacaba";

    int expected = 2;

    int result = numSplits(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1525::numSplits(std::string s) {
    int n = s.size();
    std::unordered_map<int, int> counts;

    for (auto c : s)
    {
        if (counts.contains(c))
            counts[c]++;
        else
            counts[c] = 1;
    }

    int result = 0;
    std::unordered_map<int, int> currCounts;
    for (auto c : s.substr(0, n - 1))
    {
        if (currCounts.contains(c))
            currCounts[c]++;
        else
            currCounts[c] = 1;
        if (counts[c] > 1)
            counts[c]--;
        else
            counts.erase(c);
        if (currCounts.size() == counts.size())
            result++;
    }

    return result;
}
