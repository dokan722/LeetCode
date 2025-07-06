#include "problem_2212.h"

bool problem_2212::test() {
    auto numArrows = 9;
    std::vector aliceArrows { 1, 1, 0, 1, 0, 0, 2, 1, 0, 1, 2, 0 };

    std::vector expected  { 0, 0, 0, 0, 1, 1, 0, 0, 1, 2, 3, 1 };

    auto result = maximumBobPoints(numArrows, aliceArrows);

    return expected == result;
}

std::vector<int> problem_2212::maximumBobPoints(int numArrows, std::vector<int> &aliceArrows) {
    std::vector<int> reqArrows(12);
    for (int i = 0; i < 12; i++)
    {
        reqArrows[i] = aliceArrows[i] + 1;
    }

    int bestResult = INT_MIN;
    std::vector<int> bestArrows(12);

    for (int i = 1; i < 1 << 12; ++i)
    {
        int remArrows = numArrows;
        int currPoints = 0;
        std::vector<int> currArrows(12);
        std::vector values = transformToBitArray(i);
        for (int j = 0; j < 12; ++j)
        {
            if (values[j] == 1)
            {
                currPoints += j;
                remArrows -= reqArrows[j];
                currArrows[j] = reqArrows[j];
            }

            if (currPoints > bestResult && remArrows >= 0)
            {
                currArrows[11] += remArrows;
                bestResult = currPoints;
                bestArrows = currArrows;
            }
        }
    }

    return bestArrows;
}

std::vector<int> problem_2212::transformToBitArray(int num) {
    std::vector<int> bits(12);

    for (int i = 11; i >= 0; i--)
    {
        bits[11 - i] = (num >> i) & 1;
    }

    return bits;
}
