#include "problem_3499.h"

bool problem_3499::test() {
    std::string s = "0100";

    int expected = 4;

    auto result = maxActiveSectionsAfterTrade(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3499::maxActiveSectionsAfterTrade(std::string s) {
    int n = s.size();
    std::string bs = "1" + s + "1";
    int count = -1;
    int result = 0;
    int po = 0;
    int o = 0;
    int z = 0;
    for (int i = 1; i <= n + 1; ++i)
    {
        if (bs[i] == '1')
            count++;
        if (bs[i - 1] == '1' && bs[i] == '0')
        {
            po = o;
            o = i;
        }
        else if (bs[i - 1] == '0' && bs[i] == '1')
        {
            if (z != 0)
                result = std::max(result, i - po - o + z);
            z = i;
        }
    }

    return count + result;
}
