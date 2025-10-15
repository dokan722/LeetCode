#include "problem_1247.h"

bool problem_1247::test() {
    std::string s1 = "xy";
    std::string s2 = "yx";

    int expected = 2;

    auto result = minimumSwap(s1, s2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1247::minimumSwap(std::string s1, std::string s2) {
    int n = s1.size();
    int xs = 0;
    int ys = 0;
    for (int i = 0; i < n; i++)
    {
        if (s1[i] == s2[i])
            continue;
        if (s1[i] == 'x')
            xs++;
        else
            ys++;
    }

    if (xs % 2 != ys % 2)
        return -1;
    return xs % 2 == 0 ? (xs + ys) / 2 : (ys + xs) / 2 + 1;
}
