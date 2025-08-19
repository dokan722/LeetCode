#include "problem_1647.h"

#include <unordered_map>
#include <unordered_set>

bool problem_1647::test() {
    std::string s = "aaabbbcc";


    int expected = 2;

    int result = minDeletions(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1647::minDeletions(std::string s) {
    std::vector<int> counts(26);
    for (auto c : s)
        counts[c - 'a']++;
    std::unordered_map<int, int> countsCounts;
    std::unordered_set<int> usedCounts;
    for (int i = 0; i < 26; ++i)
    {
        if (counts[i] == 0)
            continue;
        usedCounts.insert(counts[i]);
        if (countsCounts.contains(counts[i]))
            countsCounts[counts[i]]++;
        else
            countsCounts[counts[i]] = 1;
    }

    int result = 0;

    for (auto cc : countsCounts)
    {
        if (cc.second > 1)
        {
            auto smaller = cc.first;
            while (smaller >= 0 && usedCounts.contains(smaller))
                smaller--;
            for (int i = 0; i < cc.second - 1; ++i)
            {
                if (smaller != 0)
                    usedCounts.insert(smaller);
                result += cc.first - smaller;
                while (smaller >= 0 && usedCounts.contains(smaller))
                    smaller--;
            }
        }
    }

    return result;
}
