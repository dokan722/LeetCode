#include "problem_1347.h"

bool problem_1347::test() {
    std::string s = "leetcode";
    std::string t = "practice";

    int expected = 5;

    int result = minSteps(s, t);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1347::minSteps(std::string s, std::string t) {
    std::vector counts(26, 0);
    for (int i = 0; i < s.size(); i++)
    {
        counts[s[i] - 'a']++;
        counts[t[i] - 'a']--;
    }

    int result = 0;
    for (auto count : counts)
        if (count > 0)
            result += count;

    return result;
}
