#include "problem_859.h"

bool problem_859::test() {
    std::string s = "ab";
    std::string goal = "ba";

    bool expected = true;

    auto result = buddyStrings(s, goal);

    return result == expected;
}

bool problem_859::buddyStrings(std::string s, std::string goal) {
    int n = s.size();
    if (n != goal.size())
        return false;
    int diff = -1;
    bool swapped = false;
    bool multi = false;
    std::vector present(26, false);
    for (int i = 0; i < n; ++i)
    {
        if (!multi)
        {
            int id = s[i] - 'a';
            if (present[id])
                multi = true;
            else
                present[id] = true;
        }
        if (s[i] != goal[i])
        {
            if (swapped)
                return false;
            if (diff == -1)
                diff = i;
            else
            {
                if (s[i] != goal[diff] || s[diff] != goal[i])
                    return false;
                swapped = true;
            }

        }
    }

    return swapped || (diff == -1 && multi);
}
