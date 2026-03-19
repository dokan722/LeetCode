#include "problem_1208.h"

bool problem_1208::test() {
    std::string s = "iktqzyazth";
    std::string t = "havakbjzzc";
    int maxCost = 78;

    int expected = 8;

    auto result = equalSubstring(s, t, maxCost);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1208::equalSubstring(std::string s, std::string t, int maxCost) {
    int n = s.size();
    int currCost = 0;
    int r = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i > 0)
            currCost -= std::abs(s[i - 1] - t[i - 1]);
        while (r < n && currCost <= maxCost)
        {
            currCost += std::abs(s[r] - t[r]);
            r++;
        }
        result = std::max(result, r - i - 1);
        if (r == n)
        {
            if (currCost <= maxCost)
                result = std::max(result, r - i);
            break;
        }
    }

    return result;
}
