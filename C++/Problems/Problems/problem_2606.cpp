#include "problem_2606.h"

bool problem_2606::test() {
    std::string s = "adaa";
    std::string chars = "d";
    std::vector vals { -1000 };

    int expected = 2;

    auto result = maximumCostSubstring(s, chars, vals);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2606::maximumCostSubstring(std::string s, std::string chars, std::vector<int> &vals) {
    int n = s.size();
    int m = chars.size();
    std::vector<int> costs(26);
    for (int i = 0; i < 26; ++i)
        costs[i] = i + 1;
    for (int i = 0; i < m; ++i)
        costs[chars[i] - 'a'] = vals[i];

    int result = 0;
    int curr = 0;
    int mv = 'a' - 1;
    for (int i = 0; i < n; ++i)
    {
        curr += costs[s[i] - 'a'];
        result = std::max(curr, result);
        if (curr < 0)
            curr = 0;
    }

    return result;
}
