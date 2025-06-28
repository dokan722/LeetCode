#include "problem_1358.h"

bool problem_1358::test() {
    auto s = "abcabc";
    auto expected = 10;

    auto result = numberOfSubstrings(s);

    return expected == result;
}

int problem_1358::numberOfSubstrings(std::string s) {
    auto left = 0;
    int counts[3] = {0};
    auto result = 0;
    for (auto right = 0; right < s.size(); right++)
    {
        counts[s[right] - 'a']++;

        while (counts[0] > 0 && counts[1] > 0 && counts[2] > 0)
        {
            result += s.size() - right;
            counts[s[left] - 'a']--;
            left++;
        }
    }

    return result;
}
