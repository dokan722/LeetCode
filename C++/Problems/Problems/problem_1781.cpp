#include "problem_1781.h"

bool problem_1781::test() {
    std::string s = "aabcbaa";

    int expected = 17;

    auto result = beautySum(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1781::beautySum(std::string s) {
    int n = s.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        std::vector freq(26, 0);
        for (int j = i; j < n; ++j)
        {
            int top = 0;
            int bot = 2137;
            int id = s[j] - 'a';
            freq[id]++;
            for (int k = 0; k < 26; ++k)
            {
                if (freq[k] == 0)
                    continue;
                top = std::max(top, freq[k]);
                bot = std::min(bot, freq[k]);
            }

            if (bot != 2137)
                result += top - bot;
        }
    }

    return result;
}
