#include "problem_3628.h"

bool problem_3628::test() {
    std::string s = "LMCT";

    int expected = 2;

    auto result = numOfSubsequences(s);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3628::numOfSubsequences(std::string s) {
    long long ls = 0;
    long long cs = 0;
    long long ts = 0;
    for (auto c : s)
    {
        if (c == 'L')
            ls++;
        else if (c == 'C')
            cs++;
        else if (c == 'T')
            ts++;
    }
    long long count = 0;
    long long bestc = 0;
    long long bestl = 0;
    long long bestt = 0;
    long long curls = 0;
    long long curcs = 0;
    long long curts = 0;
    for (auto c : s)
    {
        if (c == 'L' || c == 'T')
        {
            bestc = std::max(bestc, curls * (ts - curts));
            if (c == 'L')
            {
                bestt += cs - curcs;
                curls++;
            }
            else
            {
                bestl += curcs;
                curts++;
            }
        }
        else if (c == 'C')
        {
            count += curls * (ts - curts);
            curcs++;
        }
    }

    return std::max(count + bestc, std::max(count + bestl, count + bestt));
}
