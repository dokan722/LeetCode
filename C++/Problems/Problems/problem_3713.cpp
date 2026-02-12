#include "problem_3713.h"

bool problem_3713::test() {
    std::string s = "zzabccy";

    int expected = 4;

    auto result = longestBalanced(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3713::longestBalanced(std::string s) {
    int n = s.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        std::vector counts(26, 0);
        for (int j = i; j < n; ++j)
        {
            counts[s[j] - 'a']++;
            int exp = counts[s[j] - 'a'];
            bool same = true;
            for (int k = 0; k < 26; ++k)
            {
                if (counts[k] != 0 && counts[k] != exp)
                {
                    same = false;
                    break;
                }
            }
            if (same)
                result = std::max(j - i + 1, result);
        }
    }

    return result;
}
