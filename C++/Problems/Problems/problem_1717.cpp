#include "problem_1717.h"

bool problem_1717::test() {
    std::string s = "cdbcbbaaabab";
    auto x = 4;
    auto y = 5;

    auto expected = 19;

    auto result = maximumGain(s, x, y);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1717::maximumGain(std::string s, int x, int y) {
    auto betterReward = std::max(x, y);
    auto worseReward = std::min(x, y);
    auto betterLetter = x > y ? 'a' : 'b';
    auto worseLetter = x > y ? 'b' : 'a';
    auto betterCount = 0;
    auto worseCount = 0;
    auto score = 0;

    for (char c : s)
    {
        if (c == betterLetter)
        {
            betterCount++;
        }
        else if (c == worseLetter)
        {
            if (betterCount > 0)
            {
                betterCount--;
                score += betterReward;
            }
            else
                worseCount++;

        }
        else
        {
            score += std::min(betterCount, worseCount) * worseReward;
            betterCount = 0;
            worseCount = 0;
        }
    }

    score += std::min(betterCount, worseCount) * worseReward;

    return score;
}
