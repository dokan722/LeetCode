#include "problem_2391.h"

bool problem_2391::test() {
    std::vector<std::string> garbage { "G", "P", "GP", "GG" };
    std::vector travel { 2, 4, 3 };

    int expected = 21;

    auto result = garbageCollection(garbage, travel);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2391::garbageCollection(std::vector<std::string> &garbage, std::vector<int> &travel) {
    int n = garbage.size();
    int p = 0;
    int g = 0;
    int m = 0;
    int cur = 0;
    int coll = garbage[0].size();
    for (int i = 1; i < n; ++i)
    {
        coll += garbage[i].size();
        cur += travel[i - 1];
        for (auto c : garbage[i])
        {
            if (c == 'G')
                g = cur;
            else if (c == 'P')
                p = cur;
            else
                m = cur;
        }
    }

    return p + g + m + coll;
}
