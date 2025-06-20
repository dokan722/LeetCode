#include "problem_3443.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_3443::test() {
    auto s = "NWSE";
    auto k = 1;

    auto expected = 3;

    auto result = maxDistance(s, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3443::maxDistance(std::string s, int k) {
    int ns = 0;
    int ss = 0;
    int ws = 0;
    int es = 0;
    auto result = 0;

    for (char c : s)
    {
        switch (c)
        {
            case 'N':
                ns++; break;
            case 'S':
                ss++; break;
            case 'W':
                ws++; break;
            case 'E':
                es++; break;
        }

        auto maxChangeNS = std::min(k, std::min(ns, ss));
        auto maxChangeWE = std::min(k - maxChangeNS, std::min(es, ws));

        auto maxDist = (std::max(ns, ss) - std::min(ns, ss)) + (std::max(ws, es) - std::min(ws, es)) + 2 * (maxChangeWE + maxChangeNS);
        if (maxDist > result)
            result = maxDist;
    }

    return result;
}
