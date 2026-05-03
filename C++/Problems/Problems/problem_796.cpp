#include "problem_796.h"

bool problem_796::test() {
    std::string s = "abcde";
    std::string goal = "cdeab";

    bool expected = true;

    auto result = rotateString(s, goal);

    std::cout << result << std::endl;

    return expected == result;
}

bool problem_796::rotateString(std::string s, std::string goal) {
    int n = s.size();
    if (n != goal.size())
        return false;
    for (int i = 0; i < n; ++i)
    {
        bool match = true;
        for (int j = 0; j < n; ++j)
        {
            if (goal[j] != s[(i + j) % n])
            {
                match = false;
                break;
            }
        }
        if (match)
            return true;
    }

    return false;
}
