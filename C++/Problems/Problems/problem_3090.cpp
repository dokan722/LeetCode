#include "problem_3090.h"

bool problem_3090::test() {
    std::string s = "bcbbbcba";

    int expected = 4;

    auto result = maximumLengthSubstring(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3090::maximumLengthSubstring(std::string s) {
    int n = s.size();
    std::vector counts(26, 0);
    int j = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        counts[s[i] - 'a']++;
        if (counts[s[i] - 'a'] == 3)
        {
            result = std::max(i - j, result);
            while (counts[s[i] - 'a'] == 3)
            {
                counts[s[j] - 'a']--;
                j++;
            }
        }
    }

    return std::max(n - j, result);
}

