#include "problem_1007.h"

bool problem_1007::test() {
    std::vector tops { 2, 1, 2, 4, 2, 2 };
    std::vector bottoms { 5, 2, 6, 2, 3, 2 };

    auto expected = 2;

    auto result = minDominoRotations(tops, bottoms);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1007::minDominoRotations(std::vector<int> &tops, std::vector<int> &bottoms) {
    int n = tops.size();
    auto possDomi = 6;
    std::vector upperNums(possDomi, 0);
    std::vector lowerNums(possDomi, 0);
    auto sameNumber = -1;
    auto same = 0;
    for (int i = 0; i < n; i++)
    {
        if (tops[i] != bottoms[i])
        {
            upperNums[tops[i] - 1]++;
            lowerNums[bottoms[i] - 1]++;
        }
        else
        {
            if (sameNumber != -1 && sameNumber != tops[i])
                return -1;
            sameNumber = tops[i];
            same++;
        }
    }

    if (sameNumber != -1)
    {
        if (upperNums[sameNumber - 1] + lowerNums[sameNumber - 1] == n - same)
            return std::min(upperNums[sameNumber - 1], lowerNums[sameNumber - 1]);
        return -1;
    }
    for (int i = 0; i < possDomi; i++)
    {
        if (upperNums[i] + lowerNums[i] == n)
            return std::min(upperNums[i], lowerNums[i]);
    }

    return -1;
}
