#include "problem_3495.h"

bool problem_3495::test() {
    std::vector<std::vector<int>> queries {{ 1, 2 }, { 2, 4 } };

    int expected = 3;

    auto result = minOperations(queries);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_3495::minOperations(std::vector<std::vector<int>> &queries) {
    long long result = 0;

    for (auto query : queries)
    {
        long long left = query[0];
        long long right = query[1];
        long long begin = 1;
        long long end = 1;
        long long numOp = 0;
        long long newOps = 0;
        while (left != 0)
        {
            left /= 4;
            begin *= 4;
            numOp++;
        }

        while (right != 0)
        {
            right /= 4;
            end *= 4;
        }

        if (begin == end)
        {
            result += ((query[1] - query[0] + 1) * numOp + 1) / 2;
            continue;
        }

        newOps += numOp * (begin - query[0]);
        while (begin != end)
        {
            numOp++;
            long next = begin * 4;
            newOps += (next - begin) * numOp;
            begin = next;
        }
        newOps -= (end - query[1] - 1) * numOp;

        result += (newOps + 1) / 2;
    }

    return result;
}
