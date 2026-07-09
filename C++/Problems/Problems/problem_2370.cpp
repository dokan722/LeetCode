#include "problem_2370.h"

bool problem_2370::test() {
    std::string s = "acfgbd";
    int k = 2;

    int expected = 4;

    auto result = longestIdealString(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2370::longestIdealString(std::string s, int k) {
    int n = s.size();
    int result = 1;
    std::vector lens(26, 0);
    for (int i = 0; i < n; ++i)
    {
        int id = s[i] - 'a';
        int best = 0;
        int from = std::max(0, id - k);
        int to = std::min(25, id + k);
        for (int j = from; j <= to; ++j)
            best = std::max(best, lens[j]);
        lens[id] = best + 1;
    }
    for (int i = 0; i < 26; ++i)
        result = std::max(result, lens[i]);
    return result;
}
