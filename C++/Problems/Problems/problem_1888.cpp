#include "problem_1888.h"

bool problem_1888::test() {
    std::string s = "111000";

    int expected = 2;

    auto result = minFlips(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1888::minFlips(std::string s) {
    int n = s.size();
    std::vector op(2, 0);

    for (int i = 0; i < n; i++)
        op[(s[i] ^ i) & 1]++;

    int res = std::min(op[0], op[1]);

    for (int i = 0; i < n - 1; i++)
    {
        op[(s[i] ^ i) & 1]--;
        op[(s[i] ^ (n + i)) & 1]++;
        res = std::min(res, std::min(op[0], op[1]));
    }

    return res;
}
