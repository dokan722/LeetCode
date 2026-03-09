#include "problem_948.h"

bool problem_948::test() {
    std::vector tokens  { 100, 200, 300, 400 };
    int power = 200;

    int expected = 2;

    auto result = bagOfTokensScore(tokens, power);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_948::bagOfTokensScore(std::vector<int> &tokens, int power) {
    int n = tokens.size();
    std::sort(tokens.begin(), tokens.end());
    int l = 0;
    int r = n - 1;
    int score = 0;
    while (l < r)
    {
        if (tokens[l] <= power)
        {
            score++;
            power -= tokens[l];
            l++;
        }
        else if (score > 0)
        {
            score--;
            power += tokens[r];
            r--;
        }
        else
            break;
    }
    if (l == r && tokens[l] <= power)
        score++;
    return score;
}
