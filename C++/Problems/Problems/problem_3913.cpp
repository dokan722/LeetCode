#include "problem_3913.h"

bool problem_3913::test() {
    std::string s = "leetcode";

    std::string expected = "leetcedo";

    auto result = sortVowels(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3913::sortVowels(std::string s) {
    int n = s.size();
    std::vector vowels { 'a', 'e', 'i', 'o', 'u' };
    std::vector first(5, -1);
    std::vector counts(5, 0);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < 5; ++j)
        {
            if (s[i] == vowels[j])
            {
                if (first[j] == -1)
                    first[j] = i;
                counts[j]++;
            }
        }
    }
    std::vector ids { 0, 1, 2, 3, 4 };
    std::sort(ids.begin(), ids.end(), [&](int a, int b) { return counts[a] == counts[b] ? first[a] < first[b] : counts[a] > counts[b];});
    int cur = 0;
    std::string result = s;
    for (int i = 0; i < n; ++i)
    {
        bool vowel = false;
        for (int j = 0; j < 5; ++j)
        {
            if (s[i] == vowels[j])
            {
                vowel = true;
                break;
            }
        }
        if (vowel)
        {
            while (counts[ids[cur]] == 0)
                cur++;
            result[i] = vowels[ids[cur]];
            counts[ids[cur]]--;
        }
        else
            result[i] = s[i];
    }

    return result;
}
