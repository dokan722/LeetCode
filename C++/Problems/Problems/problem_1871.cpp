#include "problem_1871.h"

bool problem_1871::test() {
    std::string s = "011010";
    int minJump = 2;
    int maxJump = 3;

    bool expected = true;

    auto result = canReach(s, minJump, maxJump);

    return result == expected;
}

bool problem_1871::canReach(std::string s, int minJump, int maxJump) {
    int n = s.size();
    if (s[n - 1] == '1')
        return false;
    std::vector canJump(n, false);
    canJump[0] = true;
    int cur = 0;
    for (int i = minJump; i < n; ++i)
    {
        if (canJump[i - minJump])
            cur++;
        if (i - maxJump > 0 && canJump[i - maxJump - 1])
            cur--;
        if (cur > 0 && s[i] == '0')
            canJump[i] = true;
    }

    return canJump[n - 1];
}
