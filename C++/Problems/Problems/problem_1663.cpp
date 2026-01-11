#include "problem_1663.h"

bool problem_1663::test() {
    int n = 5;
    int k = 73;

    std::string expected = "aaszz";

    auto result = getSmallestString(n, k);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1663::getSmallestString(int n, int k) {
    std::string result(n, 'a');
    k -= n;
    for (int i = n - 1; i >= 0; --i)
    {
        if (k > 25)
        {
            result[i] = 'z';
            k -= 25;
        }
        else
        {
            result[i] = (char)('a' + k);
            break;
        }
    }

    return result;
}
